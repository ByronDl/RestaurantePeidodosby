using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantePedidos
{
    public partial class FormProductos : Form
    {
        List<Producto> productos = new List<Producto>();

        ArchivoProductos archivo = new ArchivoProductos();

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            productos = archivo.Leer();

            cbTipoProducto.Items.Clear();
            cbTipoProducto.Items.Add("Bebida");
            cbTipoProducto.Items.Add("PlatoFuerte");
            cbTipoProducto.Items.Add("Postre");
            cbTipoProducto.SelectedIndex = 0;

            cbTipoBebida.Items.Clear();
            cbTipoBebida.Items.Add("Refresco");
            cbTipoBebida.Items.Add("Cerveza");
            cbTipoBebida.Items.Add("Agua");

            cbTipoCarne.Items.Clear();
            cbTipoCarne.Items.Add("Res");
            cbTipoCarne.Items.Add("Pollo");
            cbTipoCarne.Items.Add("Pescado");
            cbTipoCarne.Items.Add("Vegetariano");

            cbAcompanamiento.Items.Clear();
            cbAcompanamiento.Items.Add("Papas");
            cbAcompanamiento.Items.Add("Arroz");
            cbAcompanamiento.Items.Add("Ensalada");

            cbPorcion.Items.Clear();
            cbPorcion.Items.Add("Individual");
            cbPorcion.Items.Add("Compartir");

            cbCriterioBusqueda.Items.Clear();
            cbCriterioBusqueda.Items.Add("Código");
            cbCriterioBusqueda.Items.Add("Nombre");
            cbCriterioBusqueda.Items.Add("Tipo");
            cbCriterioBusqueda.SelectedIndex = 0;

            cbTipoBebida.SelectedIndex = 0;
            cbTipoCarne.SelectedIndex = 0;
            cbAcompanamiento.SelectedIndex = 0;
            cbPorcion.SelectedIndex = 0;

            MostrarCampos();
            Mostrar(productos);
        }

        private void cbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarCampos();
        }

        private void MostrarCampos()
        {
            bool esBebida = cbTipoProducto.Text == "Bebida";
            bool esPlato = cbTipoProducto.Text == "PlatoFuerte";
            bool esPostre = cbTipoProducto.Text == "Postre";

            textVolumen.Visible = esBebida;
            cbTipoBebida.Visible = esBebida;

            cbTipoCarne.Visible = esPlato;
            cbAcompanamiento.Visible = esPlato;

            chkAzucar.Visible = esPostre;
            cbPorcion.Visible = esPostre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCodigo.Text) ||
                string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textPrecio.Text))
            {
                MessageBox.Show("Complete los campos obligatorios");
                return;
            }

            if (!double.TryParse(textPrecio.Text, out double precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número positivo");
                return;
            }

            bool existe = productos.Any(p => p.Codigo == textCodigo.Text);

            if (existe)
            {
                MessageBox.Show("Ya existe un producto con ese código");
                return;
            }

            Producto nuevo = null;

            if (cbTipoProducto.Text == "Bebida")
            {
                if (!int.TryParse(textVolumen.Text, out int volumen) || volumen <= 0)
                {
                    MessageBox.Show("El volumen debe ser positivo");
                    return;
                }

                nuevo = new Bebida(
                    textCodigo.Text,
                    textNombre.Text,
                    precio,
                    volumen,
                    cbTipoBebida.Text
                );
            }

            if (cbTipoProducto.Text == "PlatoFuerte")
            {
                nuevo = new PlatoFuerte(
                    textCodigo.Text,
                    textNombre.Text,
                    precio,
                    cbTipoCarne.Text,
                    cbAcompanamiento.Text
                );
            }

            if (cbTipoProducto.Text == "Postre")
            {
                nuevo = new Postre(
                    textCodigo.Text,
                    textNombre.Text,
                    precio,
                    chkAzucar.Checked,
                    cbPorcion.Text
                );
            }

            productos.Add(nuevo);

            archivo.Guardar(productos);

            Mostrar(productos);

            Limpiar();

            MessageBox.Show("Producto guardado correctamente");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = cbCriterioBusqueda.Text;
            string texto = textBuscar.Text.ToLower();

            List<Producto> resultado = new List<Producto>();

            if (criterio == "Código")
            {
                resultado = productos
                    .Where(p => p.Codigo.ToLower().Contains(texto))
                    .ToList();
            }

            if (criterio == "Nombre")
            {
                resultado = productos
                    .Where(p => p.Nombre.ToLower().Contains(texto))
                    .ToList();
            }

            if (criterio == "Tipo")
            {
                resultado = productos
                    .Where(p => p.GetType().Name.ToLower().Contains(texto))
                    .ToList();
            }

            if (resultado.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados");
            }

            Mostrar(resultado);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            Mostrar(productos);
        }

        private void Mostrar(List<Producto> lista)
        {
            var datos = lista.Select(p => new
            {
                Tipo = p.GetType().Name,
                Codigo = p.Codigo,
                Nombre = p.Nombre,
                Precio = p.PrecioBase,
                Detalle = ObtenerDetalle(p)
            }).ToList();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = datos;

            lblTotal.Text = "Total productos: " + productos.Count;
        }

        private string ObtenerDetalle(Producto p)
        {
            if (p is Bebida b)
            {
                return "Volumen: " + b.VolumenMl + " ml, Tipo: " + b.Tipo;
            }

            if (p is PlatoFuerte pf)
            {
                return "Carne: " + pf.TipoCarne + ", Acompañamiento: " + pf.Acompanamiento;
            }

            if (p is Postre po)
            {
                return "Azúcar: " + (po.ContieneAzucar ? "Sí" : "No") + ", Porción: " + po.Porcion;
            }

            return "";
        }

        private void Limpiar()
        {
            textCodigo.Clear();
            textNombre.Clear();
            textPrecio.Clear();
            textVolumen.Clear();
            textBuscar.Clear();

            chkAzucar.Checked = false;

            cbTipoProducto.SelectedIndex = 0;
        }
    }
} 


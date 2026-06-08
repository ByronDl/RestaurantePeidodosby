namespace RestaurantePedidos
{
    public class Bebida : Producto
    {
        public int VolumenMl { get; set; }
        public string Tipo { get; set; }

        public Bebida()
        {
        }

        public Bebida(string codigo, string nombre, double precioBase, int volumenMl, string tipo)
            : base(codigo, nombre, precioBase)
        {
            VolumenMl = volumenMl;
            Tipo = tipo;
        }
    }
}
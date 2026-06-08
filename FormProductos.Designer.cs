namespace RestaurantePedidos
{
    partial class FormProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textVolumen = new System.Windows.Forms.TextBox();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.cbTipoProducto = new System.Windows.Forms.ComboBox();
            this.cbTipoBebida = new System.Windows.Forms.ComboBox();
            this.cbTipoCarne = new System.Windows.Forms.ComboBox();
            this.cbAcompanamiento = new System.Windows.Forms.ComboBox();
            this.cbPorcion = new System.Windows.Forms.ComboBox();
            this.cbCriterioBusqueda = new System.Windows.Forms.ComboBox();
            this.chkAzucar = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();

            this.SuspendLayout();

            // textCodigo
            this.textCodigo.Location = new System.Drawing.Point(102, 104);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 22);
            this.textCodigo.TabIndex = 0;

            // textNombre
            this.textNombre.Location = new System.Drawing.Point(260, 104);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 22);
            this.textNombre.TabIndex = 1;

            // textPrecio
            this.textPrecio.Location = new System.Drawing.Point(409, 104);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(107, 22);
            this.textPrecio.TabIndex = 2;

            // textVolumen
            this.textVolumen.Location = new System.Drawing.Point(554, 104);
            this.textVolumen.Name = "textVolumen";
            this.textVolumen.Size = new System.Drawing.Size(100, 22);
            this.textVolumen.TabIndex = 3;

            // textBuscar
            this.textBuscar.Location = new System.Drawing.Point(102, 185);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(100, 22);
            this.textBuscar.TabIndex = 4;

            // cbTipoProducto
            this.cbTipoProducto.FormattingEnabled = true;
            this.cbTipoProducto.Location = new System.Drawing.Point(83, 259);
            this.cbTipoProducto.Name = "cbTipoProducto";
            this.cbTipoProducto.Size = new System.Drawing.Size(131, 24);
            this.cbTipoProducto.TabIndex = 5;
            this.cbTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cbTipoProducto_SelectedIndexChanged);

            // cbTipoBebida
            this.cbTipoBebida.FormattingEnabled = true;
            this.cbTipoBebida.Location = new System.Drawing.Point(301, 259);
            this.cbTipoBebida.Name = "cbTipoBebida";
            this.cbTipoBebida.Size = new System.Drawing.Size(157, 24);
            this.cbTipoBebida.TabIndex = 6;

            // cbTipoCarne
            this.cbTipoCarne.FormattingEnabled = true;
            this.cbTipoCarne.Location = new System.Drawing.Point(489, 259);
            this.cbTipoCarne.Name = "cbTipoCarne";
            this.cbTipoCarne.Size = new System.Drawing.Size(121, 24);
            this.cbTipoCarne.TabIndex = 7;

            // cbAcompanamiento
            this.cbAcompanamiento.FormattingEnabled = true;
            this.cbAcompanamiento.Location = new System.Drawing.Point(83, 334);
            this.cbAcompanamiento.Name = "cbAcompanamiento";
            this.cbAcompanamiento.Size = new System.Drawing.Size(131, 24);
            this.cbAcompanamiento.TabIndex = 8;

            // cbPorcion
            this.cbPorcion.FormattingEnabled = true;
            this.cbPorcion.Location = new System.Drawing.Point(301, 334);
            this.cbPorcion.Name = "cbPorcion";
            this.cbPorcion.Size = new System.Drawing.Size(157, 24);
            this.cbPorcion.TabIndex = 9;

            // cbCriterioBusqueda
            this.cbCriterioBusqueda.FormattingEnabled = true;
            this.cbCriterioBusqueda.Location = new System.Drawing.Point(489, 334);
            this.cbCriterioBusqueda.Name = "cbCriterioBusqueda";
            this.cbCriterioBusqueda.Size = new System.Drawing.Size(121, 24);
            this.cbCriterioBusqueda.TabIndex = 10;

            // chkAzucar
            this.chkAzucar.AutoSize = true;
            this.chkAzucar.Location = new System.Drawing.Point(83, 408);
            this.chkAzucar.Name = "chkAzucar";
            this.chkAzucar.Size = new System.Drawing.Size(126, 20);
            this.chkAzucar.TabIndex = 11;
            this.chkAzucar.Text = "Contiene azúcar";
            this.chkAzucar.UseVisualStyleBackColor = true;

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(102, 483);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 29);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(260, 483);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // btnMostrarTodos
            this.btnMostrarTodos.Location = new System.Drawing.Point(409, 483);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(134, 23);
            this.btnMostrarTodos.TabIndex = 14;
            this.btnMostrarTodos.Text = "Mostrar todo";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);

            // dgvProductos
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(83, 540);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(620, 180);
            this.dgvProductos.TabIndex = 15;

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(83, 735);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 16);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total productos: 0";

            // FormProductos
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 793);

            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkAzucar);
            this.Controls.Add(this.cbCriterioBusqueda);
            this.Controls.Add(this.cbPorcion);
            this.Controls.Add(this.cbAcompanamiento);
            this.Controls.Add(this.cbTipoCarne);
            this.Controls.Add(this.cbTipoBebida);
            this.Controls.Add(this.cbTipoProducto);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.textVolumen);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCodigo);

            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textVolumen;
        private System.Windows.Forms.TextBox textBuscar;

        private System.Windows.Forms.ComboBox cbTipoProducto;
        private System.Windows.Forms.ComboBox cbTipoBebida;
        private System.Windows.Forms.ComboBox cbTipoCarne;
        private System.Windows.Forms.ComboBox cbAcompanamiento;
        private System.Windows.Forms.ComboBox cbPorcion;
        private System.Windows.Forms.ComboBox cbCriterioBusqueda;

        private System.Windows.Forms.CheckBox chkAzucar;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodos;

        private System.Windows.Forms.DataGridView dgvProductos;

        private System.Windows.Forms.Label lblTotal;
    }
}

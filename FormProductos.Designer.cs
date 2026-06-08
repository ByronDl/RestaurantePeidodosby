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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(62, 104);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(152, 22);
            this.textCodigo.TabIndex = 0;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(242, 104);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(143, 22);
            this.textNombre.TabIndex = 1;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(391, 104);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(139, 22);
            this.textPrecio.TabIndex = 2;
            // 
            // textVolumen
            // 
            this.textVolumen.Location = new System.Drawing.Point(536, 104);
            this.textVolumen.Name = "textVolumen";
            this.textVolumen.Size = new System.Drawing.Size(150, 22);
            this.textVolumen.TabIndex = 3;
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(62, 183);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(152, 22);
            this.textBuscar.TabIndex = 4;
            // 
            // cbTipoProducto
            // 
            this.cbTipoProducto.FormattingEnabled = true;
            this.cbTipoProducto.Location = new System.Drawing.Point(62, 259);
            this.cbTipoProducto.Name = "cbTipoProducto";
            this.cbTipoProducto.Size = new System.Drawing.Size(152, 24);
            this.cbTipoProducto.TabIndex = 5;
            this.cbTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cbTipoProducto_SelectedIndexChanged);
            // 
            // cbTipoBebida
            // 
            this.cbTipoBebida.FormattingEnabled = true;
            this.cbTipoBebida.Location = new System.Drawing.Point(276, 259);
            this.cbTipoBebida.Name = "cbTipoBebida";
            this.cbTipoBebida.Size = new System.Drawing.Size(157, 24);
            this.cbTipoBebida.TabIndex = 6;
            this.cbTipoBebida.SelectedIndexChanged += new System.EventHandler(this.cbTipoBebida_SelectedIndexChanged);
            // 
            // cbTipoCarne
            // 
            this.cbTipoCarne.FormattingEnabled = true;
            this.cbTipoCarne.Location = new System.Drawing.Point(479, 259);
            this.cbTipoCarne.Name = "cbTipoCarne";
            this.cbTipoCarne.Size = new System.Drawing.Size(155, 24);
            this.cbTipoCarne.TabIndex = 7;
            // 
            // cbAcompanamiento
            // 
            this.cbAcompanamiento.FormattingEnabled = true;
            this.cbAcompanamiento.Location = new System.Drawing.Point(62, 334);
            this.cbAcompanamiento.Name = "cbAcompanamiento";
            this.cbAcompanamiento.Size = new System.Drawing.Size(152, 24);
            this.cbAcompanamiento.TabIndex = 8;
            // 
            // cbPorcion
            // 
            this.cbPorcion.FormattingEnabled = true;
            this.cbPorcion.Location = new System.Drawing.Point(276, 334);
            this.cbPorcion.Name = "cbPorcion";
            this.cbPorcion.Size = new System.Drawing.Size(157, 24);
            this.cbPorcion.TabIndex = 9;
            // 
            // cbCriterioBusqueda
            // 
            this.cbCriterioBusqueda.FormattingEnabled = true;
            this.cbCriterioBusqueda.Location = new System.Drawing.Point(479, 334);
            this.cbCriterioBusqueda.Name = "cbCriterioBusqueda";
            this.cbCriterioBusqueda.Size = new System.Drawing.Size(155, 24);
            this.cbCriterioBusqueda.TabIndex = 10;
            // 
            // chkAzucar
            // 
            this.chkAzucar.AutoSize = true;
            this.chkAzucar.Location = new System.Drawing.Point(83, 408);
            this.chkAzucar.Name = "chkAzucar";
            this.chkAzucar.Size = new System.Drawing.Size(125, 20);
            this.chkAzucar.TabIndex = 11;
            this.chkAzucar.Text = "Contiene azúcar";
            this.chkAzucar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(102, 483);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 29);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(260, 483);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(409, 483);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(134, 23);
            this.btnMostrarTodos.TabIndex = 14;
            this.btnMostrarTodos.Text = "Mostrar todo";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(83, 540);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(620, 180);
            this.dgvProductos.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(83, 735);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(114, 16);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total productos: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Volumen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Buscar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tipo de producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tipo de bebida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tipo de carne";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Acompanamiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Porcion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(497, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Criterio busqueda";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 793);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

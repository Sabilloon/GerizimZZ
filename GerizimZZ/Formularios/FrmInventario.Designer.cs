namespace GerizimZZ
{
    partial class FrmInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.LineaNegraEstetica = new System.Windows.Forms.PictureBox();
            this.LogoGerizim = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lvlcodigo_Barra = new System.Windows.Forms.Label();
            this.lblcodigo_Catologo = new System.Windows.Forms.Label();
            this.lblcantidad_Producto = new System.Windows.Forms.Label();
            this.lblcantidad_Minima = new System.Windows.Forms.Label();
            this.lblestado_Producto = new System.Windows.Forms.Label();
            this.lblfecha_Ingreso = new System.Windows.Forms.Label();
            this.txtID_codigoProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio_producto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.txtPesoProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.txtCodigoCatologo = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadMinima = new System.Windows.Forms.TextBox();
            this.txtEstadoPRoducto = new System.Windows.Forms.TextBox();
            this.txtFechaingreso = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineaNegraEstetica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(10, 142);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.RowTemplate.Height = 29;
            this.dgvProducto.Size = new System.Drawing.Size(938, 205);
            this.dgvProducto.TabIndex = 25;
            this.dgvProducto.Click += new System.EventHandler(this.dgvProducto_Click);
            // 
            // LineaNegraEstetica
            // 
            this.LineaNegraEstetica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaNegraEstetica.Image = global::GerizimZZ.Properties.Resources.substract;
            this.LineaNegraEstetica.Location = new System.Drawing.Point(10, 80);
            this.LineaNegraEstetica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineaNegraEstetica.Name = "LineaNegraEstetica";
            this.LineaNegraEstetica.Size = new System.Drawing.Size(936, 26);
            this.LineaNegraEstetica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LineaNegraEstetica.TabIndex = 30;
            this.LineaNegraEstetica.TabStop = false;
            // 
            // LogoGerizim
            // 
            this.LogoGerizim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoGerizim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoGerizim.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.LogoGerizim.Location = new System.Drawing.Point(443, -8);
            this.LogoGerizim.Name = "LogoGerizim";
            this.LogoGerizim.Size = new System.Drawing.Size(120, 113);
            this.LogoGerizim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoGerizim.TabIndex = 29;
            this.LogoGerizim.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(443, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Inventario";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(753, 110);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(194, 23);
            this.txtBuscar.TabIndex = 32;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(683, 116);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(48, 15);
            this.lblBuscar.TabIndex = 31;
            this.lblBuscar.Text = "Buscar :";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(10, 356);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 15);
            this.lblCodigo.TabIndex = 34;
            this.lblCodigo.Text = "Codigo :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(18, 389);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 15);
            this.lblPrecio.TabIndex = 35;
            this.lblPrecio.Text = "Precio :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 421);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(10, 451);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 15);
            this.lblDescripcion.TabIndex = 37;
            this.lblDescripcion.Text = "Descripcion :";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(316, 356);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(38, 15);
            this.lblPeso.TabIndex = 38;
            this.lblPeso.Text = "Peso :";
            // 
            // lvlcodigo_Barra
            // 
            this.lvlcodigo_Barra.AutoSize = true;
            this.lvlcodigo_Barra.Location = new System.Drawing.Point(247, 389);
            this.lvlcodigo_Barra.Name = "lvlcodigo_Barra";
            this.lvlcodigo_Barra.Size = new System.Drawing.Size(98, 15);
            this.lvlcodigo_Barra.TabIndex = 39;
            this.lvlcodigo_Barra.Text = "Codigo de Barra :";
            // 
            // lblcodigo_Catologo
            // 
            this.lblcodigo_Catologo.AutoSize = true;
            this.lblcodigo_Catologo.Location = new System.Drawing.Point(242, 421);
            this.lblcodigo_Catologo.Name = "lblcodigo_Catologo";
            this.lblcodigo_Catologo.Size = new System.Drawing.Size(103, 15);
            this.lblcodigo_Catologo.TabIndex = 40;
            this.lblcodigo_Catologo.Text = "Codigo Catalogo :";
            // 
            // lblcantidad_Producto
            // 
            this.lblcantidad_Producto.AutoSize = true;
            this.lblcantidad_Producto.Location = new System.Drawing.Point(528, 356);
            this.lblcantidad_Producto.Name = "lblcantidad_Producto";
            this.lblcantidad_Producto.Size = new System.Drawing.Size(113, 15);
            this.lblcantidad_Producto.TabIndex = 41;
            this.lblcantidad_Producto.Text = "Cantidad Producto :";
            // 
            // lblcantidad_Minima
            // 
            this.lblcantidad_Minima.AutoSize = true;
            this.lblcantidad_Minima.Location = new System.Drawing.Point(537, 386);
            this.lblcantidad_Minima.Name = "lblcantidad_Minima";
            this.lblcantidad_Minima.Size = new System.Drawing.Size(105, 15);
            this.lblcantidad_Minima.TabIndex = 42;
            this.lblcantidad_Minima.Text = "Cantidad Minima :";
            // 
            // lblestado_Producto
            // 
            this.lblestado_Producto.AutoSize = true;
            this.lblestado_Producto.Location = new System.Drawing.Point(542, 424);
            this.lblestado_Producto.Name = "lblestado_Producto";
            this.lblestado_Producto.Size = new System.Drawing.Size(100, 15);
            this.lblestado_Producto.TabIndex = 43;
            this.lblestado_Producto.Text = "Estado Producto :";
            // 
            // lblfecha_Ingreso
            // 
            this.lblfecha_Ingreso.AutoSize = true;
            this.lblfecha_Ingreso.Location = new System.Drawing.Point(557, 453);
            this.lblfecha_Ingreso.Name = "lblfecha_Ingreso";
            this.lblfecha_Ingreso.Size = new System.Drawing.Size(86, 15);
            this.lblfecha_Ingreso.TabIndex = 44;
            this.lblfecha_Ingreso.Text = "Fecha Ingreso :";
            // 
            // txtID_codigoProducto
            // 
            this.txtID_codigoProducto.Location = new System.Drawing.Point(93, 351);
            this.txtID_codigoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_codigoProducto.Name = "txtID_codigoProducto";
            this.txtID_codigoProducto.Size = new System.Drawing.Size(130, 23);
            this.txtID_codigoProducto.TabIndex = 45;
            // 
            // txtPrecio_producto
            // 
            this.txtPrecio_producto.Location = new System.Drawing.Point(93, 384);
            this.txtPrecio_producto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio_producto.Name = "txtPrecio_producto";
            this.txtPrecio_producto.Size = new System.Drawing.Size(130, 23);
            this.txtPrecio_producto.TabIndex = 46;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(93, 416);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(130, 23);
            this.txtNombreProducto.TabIndex = 47;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(98, 446);
            this.txtDescripcionProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(400, 26);
            this.txtDescripcionProducto.TabIndex = 48;
            // 
            // txtPesoProducto
            // 
            this.txtPesoProducto.Location = new System.Drawing.Point(373, 351);
            this.txtPesoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesoProducto.Name = "txtPesoProducto";
            this.txtPesoProducto.Size = new System.Drawing.Size(126, 23);
            this.txtPesoProducto.TabIndex = 49;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(373, 381);
            this.txtCodigoBarra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(126, 23);
            this.txtCodigoBarra.TabIndex = 50;
            // 
            // txtCodigoCatologo
            // 
            this.txtCodigoCatologo.Location = new System.Drawing.Point(373, 418);
            this.txtCodigoCatologo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoCatologo.Name = "txtCodigoCatologo";
            this.txtCodigoCatologo.Size = new System.Drawing.Size(126, 23);
            this.txtCodigoCatologo.TabIndex = 51;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(667, 351);
            this.txtCantidadProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(118, 23);
            this.txtCantidadProducto.TabIndex = 52;
            // 
            // txtCantidadMinima
            // 
            this.txtCantidadMinima.Location = new System.Drawing.Point(667, 381);
            this.txtCantidadMinima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadMinima.Name = "txtCantidadMinima";
            this.txtCantidadMinima.Size = new System.Drawing.Size(118, 23);
            this.txtCantidadMinima.TabIndex = 53;
            // 
            // txtEstadoPRoducto
            // 
            this.txtEstadoPRoducto.Location = new System.Drawing.Point(667, 418);
            this.txtEstadoPRoducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstadoPRoducto.Name = "txtEstadoPRoducto";
            this.txtEstadoPRoducto.Size = new System.Drawing.Size(118, 23);
            this.txtEstadoPRoducto.TabIndex = 54;
            // 
            // txtFechaingreso
            // 
            this.txtFechaingreso.Location = new System.Drawing.Point(667, 451);
            this.txtFechaingreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaingreso.Name = "txtFechaingreso";
            this.txtFechaingreso.Size = new System.Drawing.Size(118, 23);
            this.txtFechaingreso.TabIndex = 55;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(814, 356);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 26);
            this.btnAgregar.TabIndex = 56;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(814, 398);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 26);
            this.btnModificar.TabIndex = 57;
            this.btnModificar.Text = "Modificar Producto";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(814, 442);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 26);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 483);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFechaingreso);
            this.Controls.Add(this.txtEstadoPRoducto);
            this.Controls.Add(this.txtCantidadMinima);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.txtCodigoCatologo);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.txtPesoProducto);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtPrecio_producto);
            this.Controls.Add(this.txtID_codigoProducto);
            this.Controls.Add(this.lblfecha_Ingreso);
            this.Controls.Add(this.lblestado_Producto);
            this.Controls.Add(this.lblcantidad_Minima);
            this.Controls.Add(this.lblcantidad_Producto);
            this.Controls.Add(this.lblcodigo_Catologo);
            this.Controls.Add(this.lvlcodigo_Barra);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.LineaNegraEstetica);
            this.Controls.Add(this.LogoGerizim);
            this.Controls.Add(this.dgvProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineaNegraEstetica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvProducto;
        private PictureBox LineaNegraEstetica;
        private PictureBox LogoGerizim;
        private Label label3;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Label lblCodigo;
        private Label lblPrecio;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblPeso;
        private Label lvlcodigo_Barra;
        private Label lblcodigo_Catologo;
        private Label lblcantidad_Producto;
        private Label lblcantidad_Minima;
        private Label lblestado_Producto;
        private Label lblfecha_Ingreso;
        private TextBox txtID_codigoProducto;
        private TextBox txtPrecio_producto;
        private TextBox txtNombreProducto;
        private TextBox txtDescripcionProducto;
        private TextBox txtPesoProducto;
        private TextBox txtCodigoBarra;
        private TextBox txtCodigoCatologo;
        private TextBox txtCantidadProducto;
        private TextBox txtCantidadMinima;
        private TextBox txtEstadoPRoducto;
        private TextBox txtFechaingreso;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}
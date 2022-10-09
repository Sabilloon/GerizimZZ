namespace GerizimZZ
{
    partial class FrmSolicitudInventario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudInventario));
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.LineaNegraEstetica = new System.Windows.Forms.PictureBox();
            this.LogoGerizim = new System.Windows.Forms.PictureBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreOriginal = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnIngresarSolicitud = new System.Windows.Forms.Button();
            this.txtEstadoProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID_CodigoProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesoProducto = new System.Windows.Forms.TextBox();
            this.lblcodigo_Catologo = new System.Windows.Forms.Label();
            this.txtCodigoCatalogo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadMinima = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaIngresoo = new System.Windows.Forms.TextBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LineaNegraEstetica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(334, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Solicitud Inventario";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(594, 108);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(194, 23);
            this.txtBuscar.TabIndex = 38;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(540, 113);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(48, 15);
            this.lblBuscar.TabIndex = 37;
            this.lblBuscar.Text = "Buscar :";
            // 
            // LineaNegraEstetica
            // 
            this.LineaNegraEstetica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaNegraEstetica.Image = global::GerizimZZ.Properties.Resources.substract;
            this.LineaNegraEstetica.Location = new System.Drawing.Point(-99, 78);
            this.LineaNegraEstetica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineaNegraEstetica.Name = "LineaNegraEstetica";
            this.LineaNegraEstetica.Size = new System.Drawing.Size(958, 26);
            this.LineaNegraEstetica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LineaNegraEstetica.TabIndex = 36;
            this.LineaNegraEstetica.TabStop = false;
            // 
            // LogoGerizim
            // 
            this.LogoGerizim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoGerizim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoGerizim.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.LogoGerizim.Location = new System.Drawing.Point(334, -10);
            this.LogoGerizim.Name = "LogoGerizim";
            this.LogoGerizim.Size = new System.Drawing.Size(142, 113);
            this.LogoGerizim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoGerizim.TabIndex = 35;
            this.LogoGerizim.TabStop = false;
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(42, 135);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 29;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(746, 167);
            this.dgvInventario.TabIndex = 34;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudInventario_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = " Nombre Original :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cantidad Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Codigo barra :";
            // 
            // txtProveedor
            // 
            this.txtProveedor.AutoSize = true;
            this.txtProveedor.Location = new System.Drawing.Point(44, 343);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(103, 15);
            this.txtProveedor.TabIndex = 43;
            this.txtProveedor.Text = "Estado Producto  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Descripción :";
            // 
            // txtNombreOriginal
            // 
            this.txtNombreOriginal.Location = new System.Drawing.Point(153, 307);
            this.txtNombreOriginal.Name = "txtNombreOriginal";
            this.txtNombreOriginal.Size = new System.Drawing.Size(135, 23);
            this.txtNombreOriginal.TabIndex = 45;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(410, 310);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(110, 23);
            this.txtCantidadProducto.TabIndex = 46;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.HideSelection = false;
            this.txtCodigoBarra.Location = new System.Drawing.Point(630, 310);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoBarra.TabIndex = 47;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(410, 411);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(320, 52);
            this.txtDescripcion.TabIndex = 49;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(259, 483);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(109, 38);
            this.btnSolicitar.TabIndex = 50;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // btnIngresarSolicitud
            // 
            this.btnIngresarSolicitud.Location = new System.Drawing.Point(388, 483);
            this.btnIngresarSolicitud.Name = "btnIngresarSolicitud";
            this.btnIngresarSolicitud.Size = new System.Drawing.Size(109, 39);
            this.btnIngresarSolicitud.TabIndex = 51;
            this.btnIngresarSolicitud.Text = "Ingresar Solicitud";
            this.btnIngresarSolicitud.UseVisualStyleBackColor = true;
            this.btnIngresarSolicitud.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEstadoProducto
            // 
            this.txtEstadoProducto.Location = new System.Drawing.Point(153, 340);
            this.txtEstadoProducto.Name = "txtEstadoProducto";
            this.txtEstadoProducto.Size = new System.Drawing.Size(100, 23);
            this.txtEstadoProducto.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "Codigo Producto :";
            // 
            // txtID_CodigoProducto
            // 
            this.txtID_CodigoProducto.Location = new System.Drawing.Point(153, 382);
            this.txtID_CodigoProducto.Name = "txtID_CodigoProducto";
            this.txtID_CodigoProducto.Size = new System.Drawing.Size(100, 23);
            this.txtID_CodigoProducto.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "Precio Producto :";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(153, 422);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioProducto.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 56;
            this.label8.Text = "Peso Producto :";
            // 
            // txtPesoProducto
            // 
            this.txtPesoProducto.Location = new System.Drawing.Point(410, 345);
            this.txtPesoProducto.Name = "txtPesoProducto";
            this.txtPesoProducto.Size = new System.Drawing.Size(87, 23);
            this.txtPesoProducto.TabIndex = 57;
            // 
            // lblcodigo_Catologo
            // 
            this.lblcodigo_Catologo.AutoSize = true;
            this.lblcodigo_Catologo.Location = new System.Drawing.Point(301, 382);
            this.lblcodigo_Catologo.Name = "lblcodigo_Catologo";
            this.lblcodigo_Catologo.Size = new System.Drawing.Size(103, 15);
            this.lblcodigo_Catologo.TabIndex = 58;
            this.lblcodigo_Catologo.Text = "Codigo Catalogo :";
            // 
            // txtCodigoCatalogo
            // 
            this.txtCodigoCatalogo.Location = new System.Drawing.Point(410, 377);
            this.txtCodigoCatalogo.Name = "txtCodigoCatalogo";
            this.txtCodigoCatalogo.Size = new System.Drawing.Size(87, 23);
            this.txtCodigoCatalogo.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 60;
            this.label9.Text = "Cantidad Minima :";
            // 
            // txtCantidadMinima
            // 
            this.txtCantidadMinima.Location = new System.Drawing.Point(630, 345);
            this.txtCantidadMinima.Name = "txtCantidadMinima";
            this.txtCantidadMinima.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadMinima.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 62;
            this.label10.Text = " Fecha Ingreso :";
            // 
            // txtFechaIngresoo
            // 
            this.txtFechaIngresoo.Location = new System.Drawing.Point(630, 382);
            this.txtFechaIngresoo.Name = "txtFechaIngresoo";
            this.txtFechaIngresoo.ReadOnly = true;
            this.txtFechaIngresoo.Size = new System.Drawing.Size(100, 23);
            this.txtFechaIngresoo.TabIndex = 63;
            this.txtFechaIngresoo.TextChanged += new System.EventHandler(this.txtFechaIngresoo_TextChanged);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(555, 483);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(109, 39);
            this.btnimprimir.TabIndex = 64;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(127, 483);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 38);
            this.btnLimpiar.TabIndex = 65;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmSolicitudInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 533);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.txtFechaIngresoo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCantidadMinima);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCodigoCatalogo);
            this.Controls.Add(this.lblcodigo_Catologo);
            this.Controls.Add(this.txtPesoProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID_CodigoProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIngresarSolicitud);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtEstadoProducto);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.txtNombreOriginal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.LineaNegraEstetica);
            this.Controls.Add(this.LogoGerizim);
            this.Controls.Add(this.dgvInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSolicitudInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSolicitudInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LineaNegraEstetica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private PictureBox LineaNegraEstetica;
        private PictureBox LogoGerizim;
        private DataGridView dgvInventario;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label txtProveedor;
        private Label label6;
        private TextBox txtNombreOriginal;
        private TextBox txtCantidadProducto;
        private TextBox txtCodigoBarra;
        private TextBox txtDescripcion;
        private Button btnSolicitar;
        private Button btnIngresarSolicitud;
        private TextBox txtEstadoProducto;
        private Label label5;
        private TextBox txtID_CodigoProducto;
        private Label label7;
        private TextBox txtPrecioProducto;
        private Label label8;
        private TextBox txtPesoProducto;
        private Label lblcodigo_Catologo;
        private TextBox txtCodigoCatalogo;
        private Label label9;
        private TextBox txtCantidadMinima;
        private Label label10;
        private TextBox txtFechaIngresoo;
        private Button btnimprimir;
        private System.Windows.Forms.Timer timer1;
        private Button btnLimpiar;
    }
}
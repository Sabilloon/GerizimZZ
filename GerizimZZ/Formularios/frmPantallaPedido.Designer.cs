namespace GerizimZZ
{
    partial class frmPantallaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaPedido));
            this.LogoGerizim = new System.Windows.Forms.PictureBox();
            this.LineaNegraEstetica = new System.Windows.Forms.PictureBox();
            this.BarraDeBusqueda = new System.Windows.Forms.TextBox();
            this.datagridPedidosRecientes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtRepartidor = new System.Windows.Forms.TextBox();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.txtFechaPedido = new System.Windows.Forms.TextBox();
            this.botonCancelarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineaNegraEstetica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosRecientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoGerizim
            // 
            this.LogoGerizim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoGerizim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoGerizim.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.LogoGerizim.Location = new System.Drawing.Point(201, -18);
            this.LogoGerizim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoGerizim.Name = "LogoGerizim";
            this.LogoGerizim.Size = new System.Drawing.Size(330, 117);
            this.LogoGerizim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoGerizim.TabIndex = 1;
            this.LogoGerizim.TabStop = false;
            // 
            // LineaNegraEstetica
            // 
            this.LineaNegraEstetica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaNegraEstetica.Image = global::GerizimZZ.Properties.Resources.substract;
            this.LineaNegraEstetica.Location = new System.Drawing.Point(29, 81);
            this.LineaNegraEstetica.Name = "LineaNegraEstetica";
            this.LineaNegraEstetica.Size = new System.Drawing.Size(688, 29);
            this.LineaNegraEstetica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LineaNegraEstetica.TabIndex = 5;
            this.LineaNegraEstetica.TabStop = false;
            // 
            // BarraDeBusqueda
            // 
            this.BarraDeBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraDeBusqueda.Location = new System.Drawing.Point(12, 154);
            this.BarraDeBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BarraDeBusqueda.Multiline = true;
            this.BarraDeBusqueda.Name = "BarraDeBusqueda";
            this.BarraDeBusqueda.Size = new System.Drawing.Size(305, 29);
            this.BarraDeBusqueda.TabIndex = 6;
            this.BarraDeBusqueda.TextChanged += new System.EventHandler(this.BarraDeBusqueda_TextChanged);
            // 
            // datagridPedidosRecientes
            // 
            this.datagridPedidosRecientes.AllowUserToAddRows = false;
            this.datagridPedidosRecientes.AllowUserToDeleteRows = false;
            this.datagridPedidosRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPedidosRecientes.Location = new System.Drawing.Point(12, 224);
            this.datagridPedidosRecientes.Name = "datagridPedidosRecientes";
            this.datagridPedidosRecientes.RowHeadersWidth = 51;
            this.datagridPedidosRecientes.RowTemplate.Height = 25;
            this.datagridPedidosRecientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPedidosRecientes.Size = new System.Drawing.Size(351, 200);
            this.datagridPedidosRecientes.TabIndex = 9;
            this.datagridPedidosRecientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridPedidosRecientes_CellContentClick);
            this.datagridPedidosRecientes.ClientSizeChanged += new System.EventHandler(this.PantallaDescripcionProducto_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(326, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pedidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pedidos Recientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Introduzca dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(457, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Codigo de factura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(434, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Codigo de Repartidor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(434, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Dirección de Entrega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(466, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fecha de pedido:";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(632, 198);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(100, 27);
            this.txtFactura.TabIndex = 20;
            // 
            // txtRepartidor
            // 
            this.txtRepartidor.Location = new System.Drawing.Point(632, 239);
            this.txtRepartidor.Name = "txtRepartidor";
            this.txtRepartidor.Size = new System.Drawing.Size(100, 27);
            this.txtRepartidor.TabIndex = 21;
            // 
            // txtEntrega
            // 
            this.txtEntrega.Location = new System.Drawing.Point(632, 275);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(100, 27);
            this.txtEntrega.TabIndex = 22;
            // 
            // txtFechaPedido
            // 
            this.txtFechaPedido.Location = new System.Drawing.Point(632, 309);
            this.txtFechaPedido.Name = "txtFechaPedido";
            this.txtFechaPedido.Size = new System.Drawing.Size(100, 27);
            this.txtFechaPedido.TabIndex = 23;
            // 
            // botonCancelarPedido
            // 
            this.botonCancelarPedido.Location = new System.Drawing.Point(521, 364);
            this.botonCancelarPedido.Name = "botonCancelarPedido";
            this.botonCancelarPedido.Size = new System.Drawing.Size(127, 36);
            this.botonCancelarPedido.TabIndex = 24;
            this.botonCancelarPedido.Text = "Cancelar pedido";
            this.botonCancelarPedido.UseVisualStyleBackColor = true;
            this.botonCancelarPedido.Click += new System.EventHandler(this.botonCancelarPedido_Click);
            // 
            // frmPantallaPedido
            // 
            this.ClientSize = new System.Drawing.Size(744, 446);
            this.Controls.Add(this.botonCancelarPedido);
            this.Controls.Add(this.txtFechaPedido);
            this.Controls.Add(this.txtEntrega);
            this.Controls.Add(this.txtRepartidor);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagridPedidosRecientes);
            this.Controls.Add(this.BarraDeBusqueda);
            this.Controls.Add(this.LineaNegraEstetica);
            this.Controls.Add(this.LogoGerizim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPantallaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PantallaDescripcionProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineaNegraEstetica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosRecientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private PictureBox pictureBox1;
        //private PictureBox pictureBox2;
        //public TextBox barraBusqueda;
        //private Button button1;
        //private Label label1;
        //private Button btnMinorista;
        //private Button btnInternet;
        //private Button btnMayorista;
        //private Label label2;
        //private Button btnSalir;
        //private DataGridView dataGridView1;
        private PictureBox LogoGerizim;
        private PictureBox LineaNegraEstetica;
        public TextBox BarraDeBusqueda;
        private DataGridView datagridPedidosRecientes;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtFactura;
        private TextBox txtRepartidor;
        private TextBox txtEntrega;
        private TextBox txtFechaPedido;
        private Button botonCancelarPedido;
        //private Button button1;
    }
}
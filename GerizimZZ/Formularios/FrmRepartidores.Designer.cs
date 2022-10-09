namespace GerizimZZ
{
    partial class FrmRepartidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepartidores));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.brbRepartidores = new System.Windows.Forms.TextBox();
            this.lbRepartidores = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_Barra = new System.Windows.Forms.Label();
            this.lb_inf = new System.Windows.Forms.Label();
            this.lb_CodigoPedido = new System.Windows.Forms.Label();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.lb_NombreRepartidor = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.lb_CodigoRepartidor = new System.Windows.Forms.Label();
            this.tb_CodigoRepartidor = new System.Windows.Forms.TextBox();
            this.lb_Direccion = new System.Windows.Forms.Label();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.lb_FechaPedido = new System.Windows.Forms.Label();
            this.tb_Fecha = new System.Windows.Forms.TextBox();
            this.btn_Asignar = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.pictureBox1.Location = new System.Drawing.Point(200, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::GerizimZZ.Properties.Resources.substract;
            this.pictureBox2.Location = new System.Drawing.Point(10, 89);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(545, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // brbRepartidores
            // 
            this.brbRepartidores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brbRepartidores.BackColor = System.Drawing.Color.Honeydew;
            this.brbRepartidores.Location = new System.Drawing.Point(337, 166);
            this.brbRepartidores.Multiline = true;
            this.brbRepartidores.Name = "brbRepartidores";
            this.brbRepartidores.Size = new System.Drawing.Size(205, 30);
            this.brbRepartidores.TabIndex = 6;
            this.brbRepartidores.TextChanged += new System.EventHandler(this.brbRepartidores_TextChanged);
            // 
            // lbRepartidores
            // 
            this.lbRepartidores.AutoSize = true;
            this.lbRepartidores.BackColor = System.Drawing.Color.Transparent;
            this.lbRepartidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbRepartidores.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRepartidores.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbRepartidores.Location = new System.Drawing.Point(232, 102);
            this.lbRepartidores.Name = "lbRepartidores";
            this.lbRepartidores.Size = new System.Drawing.Size(115, 21);
            this.lbRepartidores.TabIndex = 8;
            this.lbRepartidores.Text = "Repartidores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(531, 140);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb_Barra
            // 
            this.lb_Barra.AutoSize = true;
            this.lb_Barra.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Barra.Location = new System.Drawing.Point(337, 146);
            this.lb_Barra.Name = "lb_Barra";
            this.lb_Barra.Size = new System.Drawing.Size(179, 18);
            this.lb_Barra.TabIndex = 10;
            this.lb_Barra.Text = "Busqueda Repartidores :";
            // 
            // lb_inf
            // 
            this.lb_inf.AutoSize = true;
            this.lb_inf.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_inf.Location = new System.Drawing.Point(10, 194);
            this.lb_inf.Name = "lb_inf";
            this.lb_inf.Size = new System.Drawing.Size(197, 17);
            this.lb_inf.TabIndex = 11;
            this.lb_inf.Text = "Informacion de Repartidores :";
            // 
            // lb_CodigoPedido
            // 
            this.lb_CodigoPedido.AutoSize = true;
            this.lb_CodigoPedido.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_CodigoPedido.Location = new System.Drawing.Point(10, 372);
            this.lb_CodigoPedido.Name = "lb_CodigoPedido";
            this.lb_CodigoPedido.Size = new System.Drawing.Size(129, 17);
            this.lb_CodigoPedido.TabIndex = 12;
            this.lb_CodigoPedido.Text = "Codigo de Pedido :";
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.BackColor = System.Drawing.Color.Honeydew;
            this.tb_Codigo.Location = new System.Drawing.Point(200, 372);
            this.tb_Codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(195, 23);
            this.tb_Codigo.TabIndex = 13;
            // 
            // lb_NombreRepartidor
            // 
            this.lb_NombreRepartidor.AutoSize = true;
            this.lb_NombreRepartidor.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_NombreRepartidor.Location = new System.Drawing.Point(10, 402);
            this.lb_NombreRepartidor.Name = "lb_NombreRepartidor";
            this.lb_NombreRepartidor.Size = new System.Drawing.Size(159, 17);
            this.lb_NombreRepartidor.TabIndex = 14;
            this.lb_NombreRepartidor.Text = "Nombre de Repartidor :";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.BackColor = System.Drawing.Color.Honeydew;
            this.tb_Nombre.Location = new System.Drawing.Point(200, 400);
            this.tb_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(196, 23);
            this.tb_Nombre.TabIndex = 15;
            // 
            // lb_CodigoRepartidor
            // 
            this.lb_CodigoRepartidor.AutoSize = true;
            this.lb_CodigoRepartidor.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_CodigoRepartidor.Location = new System.Drawing.Point(10, 434);
            this.lb_CodigoRepartidor.Name = "lb_CodigoRepartidor";
            this.lb_CodigoRepartidor.Size = new System.Drawing.Size(152, 17);
            this.lb_CodigoRepartidor.TabIndex = 16;
            this.lb_CodigoRepartidor.Text = "Codigo de Repartidor :";
            // 
            // tb_CodigoRepartidor
            // 
            this.tb_CodigoRepartidor.BackColor = System.Drawing.Color.Honeydew;
            this.tb_CodigoRepartidor.Location = new System.Drawing.Point(200, 436);
            this.tb_CodigoRepartidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CodigoRepartidor.Name = "tb_CodigoRepartidor";
            this.tb_CodigoRepartidor.Size = new System.Drawing.Size(195, 23);
            this.tb_CodigoRepartidor.TabIndex = 17;
            // 
            // lb_Direccion
            // 
            this.lb_Direccion.AutoSize = true;
            this.lb_Direccion.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Direccion.Location = new System.Drawing.Point(10, 466);
            this.lb_Direccion.Name = "lb_Direccion";
            this.lb_Direccion.Size = new System.Drawing.Size(78, 17);
            this.lb_Direccion.TabIndex = 18;
            this.lb_Direccion.Text = "Direccion :";
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.BackColor = System.Drawing.Color.Honeydew;
            this.tb_Direccion.Location = new System.Drawing.Point(200, 466);
            this.tb_Direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(196, 23);
            this.tb_Direccion.TabIndex = 19;
            // 
            // lb_FechaPedido
            // 
            this.lb_FechaPedido.AutoSize = true;
            this.lb_FechaPedido.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_FechaPedido.Location = new System.Drawing.Point(10, 500);
            this.lb_FechaPedido.Name = "lb_FechaPedido";
            this.lb_FechaPedido.Size = new System.Drawing.Size(121, 17);
            this.lb_FechaPedido.TabIndex = 20;
            this.lb_FechaPedido.Text = "Fecha de Pedido :";
            this.lb_FechaPedido.Click += new System.EventHandler(this.lb_FechaPedido_Click);
            // 
            // tb_Fecha
            // 
            this.tb_Fecha.BackColor = System.Drawing.Color.Honeydew;
            this.tb_Fecha.Location = new System.Drawing.Point(200, 500);
            this.tb_Fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Fecha.Name = "tb_Fecha";
            this.tb_Fecha.Size = new System.Drawing.Size(195, 23);
            this.tb_Fecha.TabIndex = 21;
            this.tb_Fecha.TextChanged += new System.EventHandler(this.tb_Fecha_TextChanged);
            // 
            // btn_Asignar
            // 
            this.btn_Asignar.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Asignar.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Asignar.Location = new System.Drawing.Point(416, 434);
            this.btn_Asignar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Asignar.Name = "btn_Asignar";
            this.btn_Asignar.Size = new System.Drawing.Size(126, 22);
            this.btn_Asignar.TabIndex = 22;
            this.btn_Asignar.Text = "Asignar";
            this.btn_Asignar.UseVisualStyleBackColor = false;
            this.btn_Asignar.Click += new System.EventHandler(this.btn_Asignar_Click);
            // 
            // fecha
            // 
            this.fecha.Enabled = true;
            this.fecha.Tick += new System.EventHandler(this.fecha_Tick);
            // 
            // FrmRepartidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 544);
            this.Controls.Add(this.btn_Asignar);
            this.Controls.Add(this.tb_Fecha);
            this.Controls.Add(this.lb_FechaPedido);
            this.Controls.Add(this.tb_Direccion);
            this.Controls.Add(this.lb_Direccion);
            this.Controls.Add(this.tb_CodigoRepartidor);
            this.Controls.Add(this.lb_CodigoRepartidor);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.lb_NombreRepartidor);
            this.Controls.Add(this.tb_Codigo);
            this.Controls.Add(this.lb_CodigoPedido);
            this.Controls.Add(this.lb_inf);
            this.Controls.Add(this.lb_Barra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbRepartidores);
            this.Controls.Add(this.brbRepartidores);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRepartidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repartidores";
            this.Load += new System.EventHandler(this.FrmRepartidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public TextBox brbRepartidores;
        private Label lbRepartidores;
        private DataGridView dataGridView1;
        private Label lb_Barra;
        private Label lb_inf;
        private Label lb_CodigoPedido;
        private Label lb_NombreRepartidor;
        private Label lb_CodigoRepartidor;
        private Label lb_Direccion;
        private Label lb_FechaPedido;
        private Button btn_Asignar;
        public TextBox tb_Codigo;
        public TextBox tb_Nombre;
        public TextBox tb_CodigoRepartidor;
        public TextBox tb_Direccion;
        public TextBox tb_Fecha;
        private System.Windows.Forms.Timer fecha;
    }
}
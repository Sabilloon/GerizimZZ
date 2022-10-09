namespace GerizimZZ
{
    partial class Frm_AsignarRepartidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AsignarRepartidor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Entrega = new System.Windows.Forms.Label();
            this.lb_CodigoPedido = new System.Windows.Forms.Label();
            this.lb_NombreRepartidor = new System.Windows.Forms.Label();
            this.lb_CodigoRepartidor = new System.Windows.Forms.Label();
            this.lb_Direccion = new System.Windows.Forms.Label();
            this.lb_FechaPedido = new System.Windows.Forms.Label();
            this.tb_CodigoAS = new System.Windows.Forms.TextBox();
            this.tb_NombreAS = new System.Windows.Forms.TextBox();
            this.tb_CodigoRepartidorAS = new System.Windows.Forms.TextBox();
            this.tb_DireccionAS = new System.Windows.Forms.TextBox();
            this.tb_FechaAS = new System.Windows.Forms.TextBox();
            this.btn_Asignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.pictureBox1.Location = new System.Drawing.Point(141, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Entrega
            // 
            this.lb_Entrega.AutoSize = true;
            this.lb_Entrega.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Entrega.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_Entrega.Location = new System.Drawing.Point(24, 114);
            this.lb_Entrega.Name = "lb_Entrega";
            this.lb_Entrega.Size = new System.Drawing.Size(75, 21);
            this.lb_Entrega.TabIndex = 3;
            this.lb_Entrega.Text = "Entrega";
            this.lb_Entrega.Click += new System.EventHandler(this.lb_Entrega_Click);
            // 
            // lb_CodigoPedido
            // 
            this.lb_CodigoPedido.AutoSize = true;
            this.lb_CodigoPedido.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_CodigoPedido.Location = new System.Drawing.Point(24, 162);
            this.lb_CodigoPedido.Name = "lb_CodigoPedido";
            this.lb_CodigoPedido.Size = new System.Drawing.Size(129, 17);
            this.lb_CodigoPedido.TabIndex = 4;
            this.lb_CodigoPedido.Text = "Codigo de Pedido :";
            // 
            // lb_NombreRepartidor
            // 
            this.lb_NombreRepartidor.AutoSize = true;
            this.lb_NombreRepartidor.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_NombreRepartidor.Location = new System.Drawing.Point(24, 198);
            this.lb_NombreRepartidor.Name = "lb_NombreRepartidor";
            this.lb_NombreRepartidor.Size = new System.Drawing.Size(159, 17);
            this.lb_NombreRepartidor.TabIndex = 5;
            this.lb_NombreRepartidor.Text = "Nombre de Repartidor :";
            // 
            // lb_CodigoRepartidor
            // 
            this.lb_CodigoRepartidor.AutoSize = true;
            this.lb_CodigoRepartidor.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_CodigoRepartidor.Location = new System.Drawing.Point(24, 233);
            this.lb_CodigoRepartidor.Name = "lb_CodigoRepartidor";
            this.lb_CodigoRepartidor.Size = new System.Drawing.Size(152, 17);
            this.lb_CodigoRepartidor.TabIndex = 6;
            this.lb_CodigoRepartidor.Text = "Codigo de Repartidor :";
            // 
            // lb_Direccion
            // 
            this.lb_Direccion.AutoSize = true;
            this.lb_Direccion.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Direccion.Location = new System.Drawing.Point(24, 270);
            this.lb_Direccion.Name = "lb_Direccion";
            this.lb_Direccion.Size = new System.Drawing.Size(78, 17);
            this.lb_Direccion.TabIndex = 7;
            this.lb_Direccion.Text = "Direccion :";
            // 
            // lb_FechaPedido
            // 
            this.lb_FechaPedido.AutoSize = true;
            this.lb_FechaPedido.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_FechaPedido.Location = new System.Drawing.Point(22, 308);
            this.lb_FechaPedido.Name = "lb_FechaPedido";
            this.lb_FechaPedido.Size = new System.Drawing.Size(121, 17);
            this.lb_FechaPedido.TabIndex = 8;
            this.lb_FechaPedido.Text = "Fecha de Pedido :";
            this.lb_FechaPedido.Click += new System.EventHandler(this.lb_FechaPedido_Click);
            // 
            // tb_CodigoAS
            // 
            this.tb_CodigoAS.BackColor = System.Drawing.Color.Honeydew;
            this.tb_CodigoAS.Location = new System.Drawing.Point(228, 162);
            this.tb_CodigoAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CodigoAS.Name = "tb_CodigoAS";
            this.tb_CodigoAS.Size = new System.Drawing.Size(199, 23);
            this.tb_CodigoAS.TabIndex = 9;
            this.tb_CodigoAS.TextChanged += new System.EventHandler(this.tb_Codigo_TextChanged);
            // 
            // tb_NombreAS
            // 
            this.tb_NombreAS.BackColor = System.Drawing.Color.Honeydew;
            this.tb_NombreAS.Location = new System.Drawing.Point(228, 196);
            this.tb_NombreAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_NombreAS.Name = "tb_NombreAS";
            this.tb_NombreAS.Size = new System.Drawing.Size(199, 23);
            this.tb_NombreAS.TabIndex = 10;
            this.tb_NombreAS.TextChanged += new System.EventHandler(this.tb_Nombre_TextChanged);
            // 
            // tb_CodigoRepartidorAS
            // 
            this.tb_CodigoRepartidorAS.BackColor = System.Drawing.Color.Honeydew;
            this.tb_CodigoRepartidorAS.Location = new System.Drawing.Point(228, 229);
            this.tb_CodigoRepartidorAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CodigoRepartidorAS.Name = "tb_CodigoRepartidorAS";
            this.tb_CodigoRepartidorAS.Size = new System.Drawing.Size(199, 23);
            this.tb_CodigoRepartidorAS.TabIndex = 11;
            // 
            // tb_DireccionAS
            // 
            this.tb_DireccionAS.BackColor = System.Drawing.Color.Honeydew;
            this.tb_DireccionAS.Location = new System.Drawing.Point(228, 268);
            this.tb_DireccionAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_DireccionAS.Name = "tb_DireccionAS";
            this.tb_DireccionAS.Size = new System.Drawing.Size(198, 23);
            this.tb_DireccionAS.TabIndex = 12;
            // 
            // tb_FechaAS
            // 
            this.tb_FechaAS.BackColor = System.Drawing.Color.Honeydew;
            this.tb_FechaAS.Location = new System.Drawing.Point(228, 305);
            this.tb_FechaAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_FechaAS.Name = "tb_FechaAS";
            this.tb_FechaAS.Size = new System.Drawing.Size(198, 23);
            this.tb_FechaAS.TabIndex = 13;
            // 
            // btn_Asignar
            // 
            this.btn_Asignar.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Asignar.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Asignar.Location = new System.Drawing.Point(185, 350);
            this.btn_Asignar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Asignar.Name = "btn_Asignar";
            this.btn_Asignar.Size = new System.Drawing.Size(126, 22);
            this.btn_Asignar.TabIndex = 14;
            this.btn_Asignar.Text = "Guardar";
            this.btn_Asignar.UseVisualStyleBackColor = false;
            this.btn_Asignar.Click += new System.EventHandler(this.btn_Asignar_Click);
            // 
            // Frm_AsignarRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 383);
            this.Controls.Add(this.btn_Asignar);
            this.Controls.Add(this.tb_FechaAS);
            this.Controls.Add(this.tb_DireccionAS);
            this.Controls.Add(this.tb_CodigoRepartidorAS);
            this.Controls.Add(this.tb_NombreAS);
            this.Controls.Add(this.tb_CodigoAS);
            this.Controls.Add(this.lb_FechaPedido);
            this.Controls.Add(this.lb_Direccion);
            this.Controls.Add(this.lb_CodigoRepartidor);
            this.Controls.Add(this.lb_NombreRepartidor);
            this.Controls.Add(this.lb_CodigoPedido);
            this.Controls.Add(this.lb_Entrega);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_AsignarRepartidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Repartidor";
            this.Load += new System.EventHandler(this.Frm_AsignarRepartidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_Entrega;
        private Label lb_CodigoPedido;
        private Label lb_NombreRepartidor;
        private Label lb_CodigoRepartidor;
        private Label lb_Direccion;
        private Label lb_FechaPedido;
        private Button btn_Asignar;
        public TextBox tb_CodigoAS;
        public TextBox tb_NombreAS;
        public TextBox tb_CodigoRepartidorAS;
        public TextBox tb_DireccionAS;
        public TextBox tb_FechaAS;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}
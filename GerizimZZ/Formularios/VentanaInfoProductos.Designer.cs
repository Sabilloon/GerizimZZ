namespace GerizimZZ
{
    partial class VentanaInfoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInfoProductos));
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.Transparent;
            this.picImagen.Image = global::GerizimZZ.Properties.Resources.Imagen1_PhotoRoom__1_;
            this.picImagen.Location = new System.Drawing.Point(94, 31);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(199, 266);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 0;
            this.picImagen.TabStop = false;
            this.picImagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Garamond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(37, 291);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(325, 78);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Producto Gerizim";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblcodigo.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcodigo.Location = new System.Drawing.Point(50, 437);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(100, 24);
            this.lblcodigo.TabIndex = 3;
            this.lblcodigo.Text = "007288394";
            this.lblcodigo.Click += new System.EventHandler(this.lblcodigo_Click);
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbldescripcion.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbldescripcion.Location = new System.Drawing.Point(33, 354);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(329, 80);
            this.lbldescripcion.TabIndex = 4;
            this.lbldescripcion.Text = "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor i" +
    "ncididunt ut labore et dolore magna aliqua. ";
            this.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbldescripcion.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.BackColor = System.Drawing.Color.Transparent;
            this.lblstock.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblstock.Location = new System.Drawing.Point(151, 461);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(64, 27);
            this.lblstock.TabIndex = 7;
            this.lblstock.Text = "Stock";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.BackColor = System.Drawing.Color.Transparent;
            this.lblprecio.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblprecio.Location = new System.Drawing.Point(180, 502);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(23, 27);
            this.lblprecio.TabIndex = 8;
            this.lblprecio.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(154, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "L.";
            // 
            // VentanaInfoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerizimZZ.Properties.Resources._106_Party_Bliss;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 553);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblstock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.picImagen);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaInfoProductos";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información Producto";
            this.Load += new System.EventHandler(this.InfoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label lblNombre;
        private Label label4;
        private Label label5;
        private Label label8;
        public Label lbldescripcion;
        public Label lblcodigo;
        public Label lblstock;
        public Label lblprecio;
        public PictureBox picImagen;
    }
}
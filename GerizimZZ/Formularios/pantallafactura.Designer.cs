namespace GerizimZZ
{
    partial class pantallafactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallafactura));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.inttotalventa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.infecha = new System.Windows.Forms.TextBox();
            this.incliente = new System.Windows.Forms.TextBox();
            this.insucursal = new System.Windows.Forms.TextBox();
            this.indetalle = new System.Windows.Forms.TextBox();
            this.intotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.pictureBox1.Location = new System.Drawing.Point(213, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 238);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(550, 159);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sucursal:";
            // 
            // inttotalventa
            // 
            this.inttotalventa.AutoSize = true;
            this.inttotalventa.BackColor = System.Drawing.Color.Transparent;
            this.inttotalventa.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inttotalventa.Location = new System.Drawing.Point(296, 129);
            this.inttotalventa.Name = "inttotalventa";
            this.inttotalventa.Size = new System.Drawing.Size(110, 18);
            this.inttotalventa.TabIndex = 8;
            this.inttotalventa.Text = "Total de venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(296, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Detalle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Factura #";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(35, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de venta:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Location = new System.Drawing.Point(154, 99);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(28, 15);
            this.id.TabIndex = 13;
            this.id.Text = "###";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // infecha
            // 
            this.infecha.BackColor = System.Drawing.Color.Honeydew;
            this.infecha.Location = new System.Drawing.Point(164, 200);
            this.infecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infecha.Name = "infecha";
            this.infecha.Size = new System.Drawing.Size(110, 23);
            this.infecha.TabIndex = 18;
            this.infecha.TextChanged += new System.EventHandler(this.infecha_TextChanged);
            // 
            // incliente
            // 
            this.incliente.BackColor = System.Drawing.Color.Honeydew;
            this.incliente.Location = new System.Drawing.Point(164, 164);
            this.incliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incliente.Name = "incliente";
            this.incliente.Size = new System.Drawing.Size(110, 23);
            this.incliente.TabIndex = 19;
            // 
            // insucursal
            // 
            this.insucursal.BackColor = System.Drawing.Color.Honeydew;
            this.insucursal.Location = new System.Drawing.Point(164, 130);
            this.insucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insucursal.Name = "insucursal";
            this.insucursal.Size = new System.Drawing.Size(110, 23);
            this.insucursal.TabIndex = 20;
            // 
            // indetalle
            // 
            this.indetalle.BackColor = System.Drawing.Color.Honeydew;
            this.indetalle.Location = new System.Drawing.Point(444, 169);
            this.indetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.indetalle.Name = "indetalle";
            this.indetalle.Size = new System.Drawing.Size(110, 23);
            this.indetalle.TabIndex = 21;
            // 
            // intotal
            // 
            this.intotal.BackColor = System.Drawing.Color.Honeydew;
            this.intotal.Location = new System.Drawing.Point(444, 130);
            this.intotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.intotal.Name = "intotal";
            this.intotal.Size = new System.Drawing.Size(110, 23);
            this.intotal.TabIndex = 22;
            this.intotal.TextChanged += new System.EventHandler(this.intotal_TextChanged);
            // 
            // pantallafactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 416);
            this.Controls.Add(this.intotal);
            this.Controls.Add(this.indetalle);
            this.Controls.Add(this.insucursal);
            this.Controls.Add(this.incliente);
            this.Controls.Add(this.infecha);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inttotalventa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pantallafactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.pantallafactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label inttotalventa;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label id;
        private TextBox infecha;
        private TextBox incliente;
        private TextBox insucursal;
        private TextBox indetalle;
        private TextBox intotal;
    }
}
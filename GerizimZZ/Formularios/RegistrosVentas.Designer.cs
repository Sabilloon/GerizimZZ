namespace GerizimZZ
{
    partial class RegistrosVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosVentas));
            this.barraBusqueda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.intmensual = new System.Windows.Forms.TextBox();
            this.intventasdia = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new GerizimZZ.DataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VFactura = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.nventa = new System.Windows.Forms.TextBox();
            this.fechapago = new System.Windows.Forms.TextBox();
            this.idsucursal = new System.Windows.Forms.TextBox();
            this.idcajas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // barraBusqueda
            // 
            this.barraBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraBusqueda.BackColor = System.Drawing.Color.Honeydew;
            this.barraBusqueda.Location = new System.Drawing.Point(66, 222);
            this.barraBusqueda.Multiline = true;
            this.barraBusqueda.Name = "barraBusqueda";
            this.barraBusqueda.Size = new System.Drawing.Size(162, 22);
            this.barraBusqueda.TabIndex = 19;
            this.barraBusqueda.TextChanged += new System.EventHandler(this.barraBusqueda_TextChanged_1);
            this.barraBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.barraBusqueda_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.pictureBox1.Location = new System.Drawing.Point(240, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::GerizimZZ.Properties.Resources.substract;
            this.pictureBox2.Location = new System.Drawing.Point(25, 129);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(704, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Diario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Mensual:";
            // 
            // intmensual
            // 
            this.intmensual.BackColor = System.Drawing.Color.Honeydew;
            this.intmensual.Location = new System.Drawing.Point(144, 429);
            this.intmensual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.intmensual.Name = "intmensual";
            this.intmensual.ReadOnly = true;
            this.intmensual.Size = new System.Drawing.Size(110, 23);
            this.intmensual.TabIndex = 14;
            this.intmensual.TextChanged += new System.EventHandler(this.intsemanal_TextChanged);
            // 
            // intventasdia
            // 
            this.intventasdia.BackColor = System.Drawing.Color.Honeydew;
            this.intventasdia.Location = new System.Drawing.Point(144, 394);
            this.intventasdia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.intventasdia.Name = "intventasdia";
            this.intventasdia.ReadOnly = true;
            this.intventasdia.Size = new System.Drawing.Size(110, 23);
            this.intventasdia.TabIndex = 15;
            this.intventasdia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 259);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(400, 110);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSet11BindingSource
            // 
            this.dataSet11BindingSource.DataSource = this.dataSet11;
            this.dataSet11BindingSource.Position = 0;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Namespace = "http://tempuri.org/DataSet1.xsd";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(262, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Registros Ventas";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GerizimZZ.Properties.Resources.search;
            this.pictureBox3.Location = new System.Drawing.Point(25, 222);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Busqueda de fechas de venta";
            // 
            // VFactura
            // 
            this.VFactura.BackColor = System.Drawing.Color.Honeydew;
            this.VFactura.FlatAppearance.BorderSize = 0;
            this.VFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VFactura.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VFactura.ForeColor = System.Drawing.Color.Black;
            this.VFactura.Location = new System.Drawing.Point(518, 429);
            this.VFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VFactura.Name = "VFactura";
            this.VFactura.Size = new System.Drawing.Size(126, 28);
            this.VFactura.TabIndex = 22;
            this.VFactura.Text = "Ver Factura";
            this.VFactura.UseVisualStyleBackColor = false;
            this.VFactura.Click += new System.EventHandler(this.VFactura_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(474, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Id Venta:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(474, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fecha Pago:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(474, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Id Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(474, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Id Sucursal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(474, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Id Cajas:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Honeydew;
            this.txtid.Location = new System.Drawing.Point(598, 224);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(110, 23);
            this.txtid.TabIndex = 29;
            // 
            // nventa
            // 
            this.nventa.BackColor = System.Drawing.Color.Honeydew;
            this.nventa.Location = new System.Drawing.Point(598, 259);
            this.nventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nventa.Name = "nventa";
            this.nventa.Size = new System.Drawing.Size(110, 23);
            this.nventa.TabIndex = 34;
            // 
            // fechapago
            // 
            this.fechapago.BackColor = System.Drawing.Color.Honeydew;
            this.fechapago.Location = new System.Drawing.Point(598, 293);
            this.fechapago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechapago.Name = "fechapago";
            this.fechapago.Size = new System.Drawing.Size(110, 23);
            this.fechapago.TabIndex = 31;
            // 
            // idsucursal
            // 
            this.idsucursal.BackColor = System.Drawing.Color.Honeydew;
            this.idsucursal.Location = new System.Drawing.Point(598, 327);
            this.idsucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idsucursal.Name = "idsucursal";
            this.idsucursal.Size = new System.Drawing.Size(110, 23);
            this.idsucursal.TabIndex = 32;
            // 
            // idcajas
            // 
            this.idcajas.BackColor = System.Drawing.Color.Honeydew;
            this.idcajas.Location = new System.Drawing.Point(598, 364);
            this.idcajas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idcajas.Name = "idcajas";
            this.idcajas.Size = new System.Drawing.Size(110, 23);
            this.idcajas.TabIndex = 33;
            // 
            // RegistrosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 467);
            this.Controls.Add(this.idcajas);
            this.Controls.Add(this.idsucursal);
            this.Controls.Add(this.fechapago);
            this.Controls.Add(this.nventa);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.intventasdia);
            this.Controls.Add(this.intmensual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barraBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrosVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Ventas";
            this.Load += new System.EventHandler(this.RegistrosVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox barraBusqueda;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox intmensual;
        private TextBox intventasdia;
        private DataGridView dataGridView1;
        private Label label3;
        private DataSet1 dataSet11;
        private BindingSource dataSet11BindingSource;
        private PictureBox pictureBox3;
        private Label label4;
        private Button VFactura;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtid;
        private TextBox nventa;
        private TextBox fechapago;
        private TextBox idsucursal;
        private TextBox idcajas;
    }
}
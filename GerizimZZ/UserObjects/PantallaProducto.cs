using GerizimZZ.Clases;
using System.Data;

namespace GerizimZZ
{
    //Este user form funciona de esta forma
    /* 
     Es una plantilla la cual los campos son encapsulados para poder ser alterados
    esto permite que toda la informacion esencial del producto sea mostrada
    De igual manera este usercontrol tiene dos metodos. Uno que permite que sus datos sean enviados al detalle venta y otro
    el cual despliega la informacion del producto, 
     */
    public partial class Producto : UserControl
    {
        private int id = 0;
        private string descripcion = "Esencia que te encantara";
        private double precio = 0;
        public string estado;
        private string nom;
        private string codigobarra;
        private string textBox;
        public int cantidad = 0;
        
        public DetalleVenta dgv = new DetalleVenta();

        public Producto()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void Producto_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i <= Stockactual; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            comboBox1.SelectedIndex = 0;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string text
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }

        public string DescripcionProducto
        {
            get
            { return descripcion; }
            set
            { descripcion = value; }
        }

        public string PrecioProducto
        {
            get
            { return label1.Text; }
            set
            { label1.Text = value; }
        }

        public string NombreProducto
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        public int Stockactual
        {
            get { return Convert.ToInt32(label3.Text); }
            set { label3.Text = value.ToString(); }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Codigobarra
        {
            get { return codigobarra; }
            set { codigobarra = value; }
        }

        public Image Imagen 
        {
            get { return ImagenProducto.Image; }
            set { ImagenProducto.Image = value; }
        }
        public Label genero
        {
            get { return lblGenero; }
            set { lblGenero = value; }
        }
        public Label Aroma
        {
            get { return lblAroma; }
            set { lblAroma = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            VentanaInfoProductos pr = new VentanaInfoProductos();
            pr.lblNombre.Text = this.NombreProducto;
            pr.picImagen.Image = this.ImagenProducto.Image; 
            pr.lbldescripcion.Text = this.descripcion;
            pr.lblcodigo.Text = this.codigobarra.ToString();
            pr.lblprecio.Text = this.PrecioProducto.ToString();
            pr.lblstock.Text = this.Stockactual.ToString();
            pr.ShowDialog();
        }

        public void verificar()
        {
            if (comboBox1.Text.Length > 0)
            {
                cantidad = Convert.ToInt32(comboBox1.Text);
            }
            else
            {
                cantidad = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        
            
        }
        private void tabla ()
        {
           
            if (!(String.IsNullOrEmpty(comboBox1.Text)) && Convert.ToInt32(comboBox1.Text) <= Convert.ToInt32(label3.Text))
            {
                errorProvider1.SetError(comboBox1, "");
                if (Convert.ToInt32(comboBox1.Text) > 0)
                {
                    string precio = this.PrecioProducto;
                    textc.Id = this.Id.ToString();
                    textc.NombreProducto = this.NombreProducto;

                    string cantidadtextbox = comboBox1.Text.ToString();
                    textc.Cantidad = cantidadtextbox;
                    textc.precio = this.PrecioProducto;

                    int cantidadtextbox2 = int.Parse(cantidadtextbox);
                    string precio2 = this.PrecioProducto.ToString();
                    float precio3 = float.Parse(precio2);
                    float total = cantidadtextbox2 * precio3;
                    textc.total = total.ToString();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificar();
            tabla(); 
            if (Convert.ToDecimal(comboBox1.Text )>0)
            {
                DetalleVenta dgv = new DetalleVenta();
                dgv.llenartablita();
            }
            else
            {

            }
           

        }
    }
}
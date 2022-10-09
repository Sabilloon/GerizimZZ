namespace GerizimZZ
{
    public partial class Mensaje : UserControl
    {
        /*
         Este user control sirve de plantilla, sus valores son tomados y luego modificados. 
         */
        private string idMensaje;
        private string nombreUsuario;
        private string mensajeenviar;
        private string Fecha;
        private string importancia;

        public string IdMensaje
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }

        public string NombreUsuario
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }

        public string Mensajeenviar
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }

        public string Fecha1
        {
            get { return label6.Text; }
            set { label6.Text = value; }
        }

        public string Importancia
        {
            get { return importancia; }
            set { importancia = value; }
        }

        public Mensaje()
        {
            InitializeComponent();
        }

        public void activar(FlowLayoutPanel contenedor, string consulta)
        {
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
    }
}
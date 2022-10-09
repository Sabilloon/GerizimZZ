using GerizimZZ.Clases;

namespace GerizimZZ
{
    public partial class frmAvisos : Form
    {
        public frmAvisos()
        {
            InitializeComponent();
        }

        public void frmAvisos_Load(object sender, EventArgs e)
        {
            CsMensajes ms = new CsMensajes();
            string consulta = "select u.nombreUsuario as NombreUsuario, m.fechaEnvio as fechaEnvio, m.Id_Mensaje as IdMensaje, m.mensaje as Mensaje, m.importancia as color from Usuarios as u inner join Mensajes as m on m.Fk_Usuarios = u.ID_Usuarios where m.estado = 1 order by m.fechaEnvio DESC; ";
            ms.init(this.flowLayoutPanel1, consulta);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBox1.Text;
            CsMensajes ms = new CsMensajes();
            flowLayoutPanel1.Controls.Clear();
            string consulta = "select u.nombreUsuario as NombreUsuario, m.fechaEnvio as fechaEnvio, m.Id_Mensaje as IdMensaje, m.mensaje as Mensaje, m.importancia as color from Usuarios as u inner join Mensajes as m on m.Fk_Usuarios = u.ID_Usuarios where m.estado = 1 and m.mensaje like '%" + busqueda + "%' order by m.fechaEnvio DESC";
            ms.init(this.flowLayoutPanel1, consulta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frAgregarInformacionAviso fr = new frAgregarInformacionAviso();
            fr.ShowDialog();
        }
    }
}
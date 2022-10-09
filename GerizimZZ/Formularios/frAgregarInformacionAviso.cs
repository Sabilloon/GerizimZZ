using GerizimZZ.Clases;

namespace GerizimZZ
{
    public partial class frAgregarInformacionAviso : Form
    {
        public frAgregarInformacionAviso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int importancia = 3;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("No se puede enviar un mensaje vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!(string.IsNullOrEmpty(textBox1.Text)))
            {
                if (radioButton1.Checked)
                {
                    importancia = 1;
                }
                else if (radioButton2.Checked)
                {
                    importancia = 2;
                }
                string comando = string.Concat("use Gerizim; insert into Mensajes(fechaEnvio, mensaje, Fk_Usuarios, importancia) values(GETDATE(), '", textBox1.Text, "', (Select ID_Usuarios from Usuarios where nombreUsuario = '", Usuario.username.ToString(), "'), ", importancia, ")");
                Usuario.Conexion(comando);
                frmAvisos avisos = new frmAvisos();
                avisos.frmAvisos_Load(sender, e);
            }
        }
    }
}
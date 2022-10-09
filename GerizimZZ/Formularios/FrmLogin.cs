using GerizimZZ.Clases;

namespace GerizimZZ
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            chbxmotrar.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para recuperar su contraseña, contactese con soporte +50433510129", "Restablecer Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContraseña.Text) && string.IsNullOrEmpty(txtUsuario.Text))
            {
                errorProvider1.SetError(groupBox1, "Ingrese todos los datos para continuar"); 
            }
            else
            {
                errorProvider1.SetError(groupBox1, "");
                try
                {
                    bool entro = false;
                    Inicio inicio = new Inicio();
                    Cl_Login login = new Cl_Login();
                    entro = login.iniciarSesion(txtUsuario.Text, txtContraseña.Text);
                    Usuario.username = txtUsuario.Text;
                    if (entro)
                    {
                        this.Hide();
                        inicio.Show();
                        inicio.lblUsernma.Text = txtUsuario.Text;
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message); 
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxmotrar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Continuar", "Saliendo del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] numeros = { "+50499499796", "+50433505976", "+50496140758", "+50496671433", "+50494951699", "+50433027713" };
            Random rnd = new Random();
            int llamar = rnd.Next(0, 6);
            MessageBox.Show("Para recuperar su contraseña, contactese con soporte " + numeros[llamar], "Restablecer Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chbxmotrar.Visible = true; 
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message); 
            }
        }
    }
}
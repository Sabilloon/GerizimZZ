using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class Cl_Login
    {
        private SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
        private string nombreUsuario { get; set; }
        private string contraseñaUsuario { get; set; }

        public bool iniciarSesion(string nombreUsuario, string contraseñaUsuario)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseñaUsuario = contraseñaUsuario;
            FrmLogin login = new FrmLogin();
            bool entro = false;
            string sql = "SELECT * FROM Usuarios WHERE nombreUsuario = '" + nombreUsuario + "' AND contraseñaUsuario = '" + contraseñaUsuario + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bienvenido/a de nuevo " + dr[1].ToString(), "Log In Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                entro = true;
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return entro;
        }
    }
}
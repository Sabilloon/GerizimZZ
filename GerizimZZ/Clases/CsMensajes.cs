using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class CsMensajes: Cl_conexiones
    {
        private string nombre_usuario;
        private string fecha = "Hoy";
        private string idMensaje;
        private string mensajeenviado = "Hola";
        private string impor;
        public string Mensajeenviado { get => mensajeenviado; set => mensajeenviado = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string IdMensaje { get => idMensaje; set => idMensaje = value; }
        public string Impor { get => impor; set => impor = value; }

       
        public void init(FlowLayoutPanel panel, string consulta)
        {
            conex.Open();

            SqlCommand comando = new SqlCommand(consulta, conex);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                nombre_usuario = reader[0].ToString();
                mensajeenviado = reader[3].ToString();
                fecha = reader[1].ToString();
                IdMensaje = reader[2].ToString();
                impor = reader["color"].ToString();
                Mensaje ms = new Mensaje();
                ms.IdMensaje = idMensaje;
                ms.NombreUsuario = nombre_usuario;
                ms.Fecha1 = fecha;
                ms.Mensajeenviar = mensajeenviado;
                ms.Importancia = impor;
                if (ms.Importancia == "3")
                {
                    ms.panel2.BackColor = Color.DarkCyan;
                }
                else if (ms.Importancia == "2")
                {
                    ms.panel2.BackColor = Color.YellowGreen;
                }
                else if (ms.Importancia == "1")
                {
                    ms.panel2.BackColor = Color.SpringGreen;
                }
                else
                {
                    ms.panel2.BackColor = Color.Chartreuse;
                }
                panel.Controls.Add(ms);
            }

            conex.Close();
            conex.Dispose();
        }
    }
}
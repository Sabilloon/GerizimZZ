using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    public static class Usuario
    {
        public static string username;

        public static void Conexion(string consulta)
        {
            int cambio;
            SqlConnection conexion = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            cambio = comando.ExecuteNonQuery();
            if (cambio == 1)
            {
                MessageBox.Show("Accion Ejecutada");
            }
            else { MessageBox.Show("No se realizo ninguna accion"); }

            conexion.Close();
        }

        public static void ConexionSinMensaje(string consulta)
        {
            int cambio;
            SqlConnection conexion = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            cambio = comando.ExecuteNonQuery();
        }
    }
}
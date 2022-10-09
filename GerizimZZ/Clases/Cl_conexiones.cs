using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    public class Cl_conexiones
    {
        public SqlDataReader read;
        protected SqlConnection conex = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        public SqlCommand cm;
        public void conexOpen()
        {
            conex.Open();
        }
        protected SqlConnection Conex { get => conex; set => conex = value; }
    }
}
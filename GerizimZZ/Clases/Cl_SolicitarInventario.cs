using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class Cl_SolicitarInventario
    {
        private SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");

        private static SqlConnection GetConnection()
        {
            SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
            return conec;
        }

        public static DataTable GetAll()
        {
            SqlConnection conec = GetConnection();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conec;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Producto";
            using (conec)
            {
                conec.Open();
                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
        }

        public void Agregar_Solicitud(int ID_codigoProducto, double Precio_producto, string NombreProducto, double PesoProducto, string CodigoBarra, string CodigoCatologo, int CantidadProducto, int CantidadMinima, string DescripcionProducto, int EstadoPRoducto, DateTime Fechaingreso)
        {
            DialogResult result = MessageBox.Show("Seguro que desea solicitar el producto?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = "INSERT INTO Producto(ID_codigoProducto, Precio_producto, NombreProducto, PesoProducto, CodigoBarra, CodigoCatologo, CantidadProducto, CantidadMinima, DescripcionProducto, EstadoPRoducto, Fechaingreso) VALUES ('"
                    + ID_codigoProducto + "','" + Precio_producto + "','" + NombreProducto + "','" + PesoProducto + "','" + CodigoBarra + "','" + CodigoCatologo +
                    "','" + CantidadProducto + "','" + CantidadMinima + "','" + DescripcionProducto + "','" + EstadoPRoducto + "','" + Convert.ToDateTime(Fechaingreso) + "')";
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(sql, conec);
                    cmd.ExecuteNonQuery();
                    conec.Close();
                    MessageBox.Show("Registro agregado con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }
    }
}
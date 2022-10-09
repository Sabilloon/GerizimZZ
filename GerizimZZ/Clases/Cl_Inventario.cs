using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class Cl_Inventario : Cl_conexiones
    {
        private SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
        private int iD_codigoProducto;
        private double precio_producto;
        private string nombreProducto;
        private double pesoProducto;
        private string codigoBarra;
        private string codigoCatologo;
        private int cantidadProducto;
        private int cantidadMinima;
        private string descripcionProducto;
        private int estadoPRoducto;
        private string fechaingreso;

        public int ID_codigoProducto { get => iD_codigoProducto; set => iD_codigoProducto = value; }
        public double Precio_producto { get => precio_producto; set => precio_producto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double PesoProducto { get => pesoProducto; set => pesoProducto = value; }
        public string CodigoBarra { get => codigoBarra; set => codigoBarra = value; }
        public string CodigoCatologo { get => codigoCatologo; set => codigoCatologo = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public int CantidadMinima { get => cantidadMinima; set => cantidadMinima = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public int EstadoPRoducto { get => estadoPRoducto; set => estadoPRoducto = value; }
        public string Fechaingreso { get => fechaingreso; set => fechaingreso = value; }

        private static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
            return con;
        }

        public static DataTable GetAll()
        {
            SqlConnection con = GetConnection();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Producto";
            using (con)
            {
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
        }

        public void Agregar_Producto(int ID_codigoProducto, double Precio_producto, string NombreProducto, double PesoProducto, string CodigoBarra, string CodigoCatologo, int CantidadProducto, int CantidadMinima, string DescripcionProducto, int EstadoPRoducto, string Fechaingreso)
        {
            DialogResult result = MessageBox.Show("Seguro que desea agregar el producto?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = "INSERT INTO Producto(ID_codigoProducto, Precio_producto, NombreProducto, PesoProducto, CodigoBarra, CodigoCatologo, CantidadProducto, CantidadMinima, DescripcionProducto, EstadoPRoducto) VALUES ('"
                    + ID_codigoProducto + "','" + Precio_producto + "','" + NombreProducto + "','" + PesoProducto + "','" + CodigoBarra + "','" + CodigoCatologo +
                    "','" + CantidadProducto + "','" + CantidadMinima + "','" + DescripcionProducto + "','" + EstadoPRoducto  + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        con.Close();
                        MessageBox.Show("Registro agregado con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                   
                }catch( Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        public void Modificar_Producto(int ID_codigoProducto, double Precio_producto, string NombreProducto, double PesoProducto, string CodigoBarra, string CodigoCatologo, int CantidadProducto, int CantidadMinima, string DescripcionProducto, int EstadoPRoducto)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Modificar el producto?", "Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = "UPDATE Producto SET precio_producto = '" +
                Precio_producto + "', nombreProducto = '" +
                NombreProducto + "', pesoProducto = '" +
                PesoProducto + "', codigoBarra = '" +
                CodigoBarra + "', codigoCatologo = '" +
                CodigoCatologo + "', cantidadProducto  = '" +
                CantidadProducto + "', cantidadMinima  = '" +
                CantidadMinima + "', descripcionProducto  = '" +
                DescripcionProducto + "', estadoPRoducto  = '" +
                EstadoPRoducto + "' WHERE ID_codigoProducto = '" +
                ID_codigoProducto + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Eliminar_Producto(int ID_codigoProducto)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Eliminar?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM Producto WHERE ID_codigoProducto = '" + ID_codigoProducto + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro eliminado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class Cl_Clientes : Cl_conexiones
    {
        
        private SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
        private string iD_cliente;
        private string primerNombre_Cliente;
        private string segundoNombre_Cliente;
        private string primerApellido_Cliente;
        private string segunndoApellido_Cliente;
        private string direccion_Cliente;
        private string telefono_Cliente;

        public string ID_cliente { get => iD_cliente; set => iD_cliente = value; }
        public string PrimerNombre_Cliente { get => primerNombre_Cliente; set => primerNombre_Cliente = value; }
        public string SegundoNombre_Cliente { get => segundoNombre_Cliente; set => segundoNombre_Cliente = value; }
        public string PrimerApellido_Cliente { get => primerApellido_Cliente; set => primerApellido_Cliente = value; }
        public string SegunndoApellido_Cliente { get => segunndoApellido_Cliente; set => segunndoApellido_Cliente = value; }
        public string Direccion_Cliente { get => direccion_Cliente; set => direccion_Cliente = value; }
        public string Telefono_Cliente { get => telefono_Cliente; set => telefono_Cliente = value; }

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
            comando.CommandText = "SELECT * FROM Cliente";
            using (con)
            {
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
        }

        public void Agregar_Cliente(string ID_cliente, string primerNombre_Cliente, string segundoNombre_Cliente, string primerApellido_Cliente, string segundoApellido_Cliente, string Telefono_Cliente, string Direccion_Cliente)
        {
            DialogResult result = MessageBox.Show("Seguro que desea agregar el cliente?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = "INSERT INTO Cliente(ID_cliente, primerNombre, segundoNombre, primerApellido, SegundoApellido, telefono, direccion) VALUES ('"
                + ID_cliente + "','" + primerNombre_Cliente + "','" + segundoNombre_Cliente + "','"
                + primerApellido_Cliente + "','" + segundoApellido_Cliente + "','" + Telefono_Cliente + "','" + Direccion_Cliente + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro agregado con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar_Cliente(string ID_cliente, string primerNombre_Cliente, string segundoNombre_Cliente, string primerApellido_Cliente, string segundoApellido_Cliente, string Direccion_Cliente, string Telefono_Cliente)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Modificar el cliente?", "Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = "UPDATE Cliente SET primerNombre = '" +
                primerNombre_Cliente + "', segundoNombre = '" +
                segundoNombre_Cliente + "', primerApellido = '" +
                primerApellido_Cliente + "', SegundoApellido = '" +
                segundoApellido_Cliente + "', telefono = '" +
                Telefono_Cliente + "', direccion  = '" +
                Direccion_Cliente + "' WHERE ID_cliente = '" +
                ID_cliente + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Eliminar_Cliente(string ID_cliente)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Eliminar?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM Cliente WHERE ID_cliente = '" + ID_cliente + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro eliminado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
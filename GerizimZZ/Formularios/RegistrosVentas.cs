using GerizimZZ.Clases;
using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ
{
    public partial class RegistrosVentas : Form

    {
        public RegistrosVentas()
        {
            InitializeComponent();
            calculosDiarios();
            calculosMensuales();
        }

        private ConexionVentascs cmda = new ConexionVentascs();

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void RegistrosVentas_Load(object sender, EventArgs e)
        {
            cmda.llenargrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nventa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fechapago.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            idsucursal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            idcajas.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void barraBusqueda_TextChanged_1(object sender, EventArgs e)
        {
        }

        private SqlConnection conectarr = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        private void barraBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            conectarr.Open();
            SqlCommand cmda = conectarr.CreateCommand();

            cmda.CommandType = CommandType.Text;
            cmda.CommandText = "SELECT * FROM Factura where ID_cliente like ('" + barraBusqueda.Text + "%')";
            cmda.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmda);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conectarr.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void VFactura_Click(object sender, EventArgs e)
        {
            pantallafactura rc = new pantallafactura();
            rc.ShowDialog();
        }

        private void VPedido_Click(object sender, EventArgs e)
        {
            //RegistroPedido rc = new RegistroPedido();
            //rc.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void intsemanal_TextChanged(object sender, EventArgs e)
        {
        }

        public void calculosDiarios()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source = localhost ; Initial Catalog = Gerizim; Integrated Security = True");
                SqlCommand comando = new SqlCommand("exec totalDiario; ", conexion);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() && !registro.IsDBNull(0))
                {
                    intventasdia.Text = registro[0].ToString();
                }
                else
                {
                    intventasdia.Text = "0";
                }

                conexion.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void calculosMensuales()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source = localhost ; Initial Catalog = Gerizim; Integrated Security = True");
                SqlCommand comando = new SqlCommand("exec totalMensual; ", conexion);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() && !registro.IsDBNull(0))
                {
                    intmensual.Text = registro[0].ToString();
                }
                else
                {
                    intmensual.Text = "0";
                }

                conexion.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
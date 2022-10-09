using GerizimZZ.Clases;
using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ
{
    public partial class FrmRepartidores : Form
    {
        private SqlConnection conec = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        public FrmRepartidores()
        {
            InitializeComponent();
        }

        private Cl_Repartidores cmda = new Cl_Repartidores();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void FrmRepartidores_Load(object sender, EventArgs e)
        {
            cmda.infogrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llenar textboxt con datos del datagridview
            tb_Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_CodigoRepartidor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void brbRepartidores_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conectarr = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");
            //Codigo para crear la barra de busqueda por nombres de repartidores.
            conectarr.Open();
            SqlCommand cmda = conectarr.CreateCommand();

            cmda.CommandType = CommandType.Text;
            cmda.CommandText = "SELECT * FROM Repartidores where nombreRepartidor like ('" + brbRepartidores.Text + "%')";
            cmda.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmda);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conectarr.Close();
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            //Llamar datos de los Textboxt a otro form
            Frm_AsignarRepartidor fasignar = new Frm_AsignarRepartidor();
            fasignar.tb_CodigoAS.Text = tb_Codigo.Text;
            fasignar.tb_DireccionAS.Text = tb_Direccion.Text;
            fasignar.tb_NombreAS.Text = tb_Nombre.Text;
            fasignar.tb_FechaAS.Text = tb_Fecha.Text;
            fasignar.tb_CodigoRepartidorAS.Text = tb_CodigoRepartidor.Text;

            fasignar.Show();
        }

        private void tb_Fecha_TextChanged(object sender, EventArgs e)
        {
        }

        private void fecha_Tick(object sender, EventArgs e)
        {
            //Fecha automatica
            tb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void lb_FechaPedido_Click(object sender, EventArgs e)
        {
        }
    }
}
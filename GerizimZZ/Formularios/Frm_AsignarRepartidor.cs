using GerizimZZ.Clases;
using System.Data.SqlClient;

namespace GerizimZZ
{
    public partial class Frm_AsignarRepartidor : Form
    {
        private SqlConnection conec = new SqlConnection("Data Source=localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        public Frm_AsignarRepartidor()
        {
            InitializeComponent();
        }

        private Cl_Repartidores cmda = new Cl_Repartidores();

        private void lb_FechaPedido_Click(object sender, EventArgs e)
        {
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrega Asignada Correctamente");
            this.Close();
        }

        private void Frm_AsignarRepartidor_Load(object sender, EventArgs e)
        {
        }

        private void tb_Codigo_TextChanged(object sender, EventArgs e)
        {
        }

        private void lb_Entrega_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void tb_Nombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Continuar?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
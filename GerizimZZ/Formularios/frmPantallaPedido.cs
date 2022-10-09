using GerizimZZ.Clases;
using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ
{
    public partial class frmPantallaPedido : Form

    {
        //Inicia el formulario
        public frmPantallaPedido()
        {
            InitializeComponent();
        }

        private void PantallaDescripcionProducto_Load(object sender, EventArgs e)
        {
            cmda.llenargrid(datagridPedidosRecientes);
        }

        //Clase para cerrar form
        //private void CerrarForm (object sender, EventArgs e)
        //{
        //    Inicio FrmPrincipal = new Inicio();
        //    this.Hide();
        //    FrmPrincipal.Show();

        private ConexionPedido cmda = new ConexionPedido();

        //_______________________________________________________________________________
        private SqlConnection conectaa = new SqlConnection("Data Source =TATO180\\SQLEXPRESS ; Initial Catalog =Gerizim ; Integrated Security = True");

        private void BarraDeBusqueda_TextChanged(object sender, EventArgs e)
        {
            conectaa.Open();

            SqlCommand cmd = conectaa.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " SELECT * FROM Pedidos where direccionEntrega LIKE ('" + BarraDeBusqueda.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            datagridPedidosRecientes.DataSource = dt;

            conectaa.Close();
        }

        //Agarra valores de las celdas del datagrid y las puestra en los textbox
        private void datagridPedidosRecientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFactura.Text = datagridPedidosRecientes.CurrentRow.Cells[5].Value.ToString();
            txtRepartidor.Text = datagridPedidosRecientes.CurrentRow.Cells[3].Value.ToString();
            txtEntrega.Text = datagridPedidosRecientes.CurrentRow.Cells[4].Value.ToString();
            txtFechaPedido.Text = datagridPedidosRecientes.CurrentRow.Cells[1].Value.ToString();
        }

        private void botonCancelarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el pedido?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Pedido Cancelado");
                txtEntrega.Clear();
                txtFechaPedido.Clear();
                txtRepartidor.Clear();
                txtFechaPedido.Clear();
                txtFactura.Clear();
            }
            //if (MessageBox.Show("¿Desea cancelar el pedido?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            //{
            //    MessageBox.Show("")

            //}
        }

        //private void PantallaDescripcionProducto_Load(object sender, EventArgs e)
        //{
        //   cmda.llenargrid(datagridPedidosRecientes);
        //    //para cerrar Form y abrir el principal al tocar la "x"
        //   // this.FormClosed += new FormClosedEventHandler(CerrarForm);
        //}
        //Clase para cerrar form
        //private void CerrarForm (object sender, EventArgs e)
        //{
        //    Inicio FrmPrincipal = new Inicio();
        //    this.Hide();
        //    FrmPrincipal.Show();

        //}
    }
}
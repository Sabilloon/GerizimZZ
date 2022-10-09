using GerizimZZ.Clases;
using GerizimZZ.Datasets;
using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ
{
    public partial class FrmInventario : Form
    {
        private Cl_Inventario productos = new Cl_Inventario();
        private Productosdst dstProducto;
        private DataTable dtProducto;
        private int codigo, cantidadproducto, cantidadminima, estadoproducto;
        private double precio_producto, pesoproducto;

        public FrmInventario()
        {
            InitializeComponent();
            txtFechaingreso.Text = DateTime.Now.ToString("yyyy'-'mm'-'dd' 'hh:mm");
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            dtProducto = Cl_Inventario.GetAll();
            dstProducto = new Productosdst();
            dstProducto.Tables.Add(dtProducto);
            dgvProducto.DataSource = dstProducto.Tables[0];
        }

        private void dgvProducto_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvProducto.SelectedRows)
            {
                txtID_codigoProducto.Text = item.Cells[0].Value.ToString();
                txtPrecio_producto.Text = item.Cells[1].Value.ToString();
                txtNombreProducto.Text = item.Cells[2].Value.ToString();
                txtPesoProducto.Text = item.Cells[3].Value.ToString();
                txtCodigoBarra.Text = item.Cells[4].Value.ToString();
                txtCodigoCatologo.Text = item.Cells[5].Value.ToString();
                txtCantidadProducto.Text = item.Cells[6].Value.ToString();
                txtCantidadMinima.Text = item.Cells[7].Value.ToString();
                txtDescripcionProducto.Text = item.Cells[8].Value.ToString();
                txtEstadoPRoducto.Text = item.Cells[9].Value.ToString();
                txtFechaingreso.Text = item.Cells[10].Value.ToString();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dstProducto.Tables[0].DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "ID_codigoProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Precio_producto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "NombreProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "PesoProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CodigoBarra", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CodigoCatologo", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CantidadProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CantidadMinima", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "DescripcionProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "EstadoPRoducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Fechaingreso", txtBuscar.Text);
            dgvProducto.DataSource = dstProducto.Tables[0].DefaultView;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCatologo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == ""  || txtID_codigoProducto.Text == "" || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                codigo = Convert.ToInt32(txtID_codigoProducto.Text);
                cantidadproducto = Convert.ToInt32(txtCantidadProducto.Text);
                cantidadminima = Convert.ToInt32(txtCantidadMinima.Text);
                estadoproducto = Convert.ToInt32(txtEstadoPRoducto.Text);
                precio_producto = Convert.ToDouble(txtPrecio_producto.Text);
                pesoproducto = Convert.ToDouble(txtPesoProducto.Text);

                productos.Agregar_Producto(codigo, precio_producto, txtNombreProducto.Text, pesoproducto, txtCodigoBarra.Text, txtCodigoCatologo.Text, cantidadproducto, cantidadminima, txtDescripcionProducto.Text, estadoproducto, txtFechaingreso.Text);
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                SqlDataAdapter comando = new SqlDataAdapter();
                string sql = "SELECT * FROM Producto";
                comando.SelectCommand = new SqlCommand(sql, con);
                dtProducto = Cl_Inventario.GetAll();
                dstProducto = new Productosdst();
                dstProducto.Tables.Add(dtProducto);
                dgvProducto.DataSource = dstProducto.Tables[0];
                con.Close();
              
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCatologo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == "" || txtFechaingreso.Text == "" || txtID_codigoProducto.Text == "" || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                codigo = Convert.ToInt32(txtID_codigoProducto.Text);
                cantidadproducto = Convert.ToInt32(txtCantidadProducto.Text);
                cantidadminima = Convert.ToInt32(txtCantidadMinima.Text);
                estadoproducto = Convert.ToInt32(txtEstadoPRoducto.Text);
                precio_producto = Convert.ToDouble(txtPrecio_producto.Text);
                pesoproducto = Convert.ToDouble(txtPesoProducto.Text);
                productos.Modificar_Producto(codigo, precio_producto, txtNombreProducto.Text, pesoproducto, txtCodigoBarra.Text, txtCodigoCatologo.Text, cantidadproducto, cantidadminima, txtDescripcionProducto.Text, estadoproducto);
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                SqlDataAdapter comando = new SqlDataAdapter();
                string sql = "SELECT * FROM Producto";
                comando.SelectCommand = new SqlCommand(sql, con);
                dtProducto = Cl_Inventario.GetAll();
                dstProducto = new Productosdst();
                dstProducto.Tables.Add(dtProducto);
                dgvProducto.DataSource = dstProducto.Tables[0];
                con.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCatologo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == "" || txtFechaingreso.Text == "" || txtID_codigoProducto.Text == "" || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ID_codigoProducto;
                foreach (DataGridViewRow item in this.dgvProducto.SelectedRows)
                {
                    ID_codigoProducto = item.Cells[0].Value.ToString();
                    productos.Eliminar_Producto(Convert.ToInt32(ID_codigoProducto));
                }
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                SqlDataAdapter comando = new SqlDataAdapter();
                string sql = "SELECT * FROM Producto";
                comando.SelectCommand = new SqlCommand(sql, con);
                dtProducto = Cl_Inventario.GetAll();
                dstProducto = new Productosdst();
                dstProducto.Tables.Add(dtProducto);
                dgvProducto.DataSource = dstProducto.Tables[0];
                con.Close();
            }
        }
    }
}
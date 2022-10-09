using IronBarCode;
using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ
{
    public partial class frCodigoBarra : Form
    {
        /*
         Este formulario sirve junto al lector de vcodigo de barras. 
        la funcion que realiza es la siguiente. Toma el valor del textboxt, y segun este realiza una busqueda en la base de datos
        si ese valor existe, mostrara la imagen, nombre, y la cantidad del producto. De no ser asi, mostrará una imagen
        haciendo referencia que el producto no fue encontrado. 

         */
        string verificacionNombre; 
        private SqlCommand cmd;
        private bool existe = false;
        private SqlConnection connection = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        public frCodigoBarra()
        {
            InitializeComponent();
        }
        //al existir dos metodos de busqueda, uno por imagen y otro mediante una imagen. este boton permite
        //que se busque las imagen

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png" })

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    BarcodeResult codigoLeido = BarcodeReader.QuicklyReadOneBarcode(pictureBox1.Image, BarcodeEncoding.QRCode | BarcodeEncoding.Code128, true);

                    if (codigoLeido != null)
                    {
                        textBox1.Text = codigoLeido.ToString();
                    }
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        //ESTE BOTON INCLUYE MUchas funciones. La primera es verificar que los datos esten llenados. De igual manera comprobara
        //si los datos ingresados existen en el datagrid de venta, o si la cantidad seleccionada es correcta

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean productoEnElCarrito = false;
            int pos = 0;
            int[] cantidad = new int[2];

            if ((string.IsNullOrEmpty(textBox1.Text) == true))
            {
                errorProvider1.SetError(groupBox1, "Ingrese todos los datos");
            }
            else if (existe == true && string.IsNullOrEmpty(textBox1.Text) == false && textBox1.Text.Length > 6 && string.Compare(lblNombre.Text, verificacionNombre)== 0)
            {
                errorProvider1.SetError(groupBox1, "");
                SqlCommand consulta = new SqlCommand("Select ID_codigoProducto, precio_producto, nombreProducto, cantidadProducto, estadoPRoducto from Producto where codigoBarra = '" + textBox1.Text + "';", connection);
                connection.Open();
                try
                {
                    SqlDataReader registro = consulta.ExecuteReader();
                    if (registro.Read())
                    {
                        cantidad[1] = Convert.ToInt32(registro[3]);
                        if (Convert.ToInt32(registro[4]) != 0 && Convert.ToInt32(cmbCantidad.Text) <= Convert.ToInt32(registro[3]))
                        {
                            DetalleVenta dv = Owner as DetalleVenta;
                            DataTable dt = new DataTable();

                            for (int i = 0; i < dv.dgDetalleVenta.Rows.Count; i++)
                            {
                                if (Convert.ToInt32(dv.dgDetalleVenta.Rows[i].Cells[0].Value) == Convert.ToInt32(registro["ID_codigoProducto"]))
                                {
                                    productoEnElCarrito = true;
                                    pos = i;
                                    cantidad[0] = Convert.ToInt32(dv.dgDetalleVenta.Rows[i].Cells[2].Value);
                                }
                            }

                            dt = dv.dgDetalleVenta.DataSource as DataTable;
                            DataRow datarow;
                            datarow = dt.NewRow();
                            if (productoEnElCarrito == false)
                            {
                                if (dt.Columns.Count == 0)
                                {
                                    dt.Columns.Add("Id");
                                    dt.Columns.Add("Nombre");
                                    dt.Columns.Add("Cantidad");
                                    dt.Columns.Add("Precio");
                                    dt.Columns.Add("Total");
                                }
                                if (Convert.ToInt32(cmbCantidad.Text) > 0)
                                {
                                    datarow["Id"] = registro[0].ToString();
                                    datarow["Nombre"] = registro[2].ToString();

                                    datarow["Cantidad"] = cmbCantidad.Text;

                                    datarow["Precio"] = registro[1].ToString();

                                    datarow["Total"] = (Convert.ToInt32(cmbCantidad.Text) * Convert.ToInt32(registro[1])).ToString();
                                    dt.Rows.Add(datarow);
                                }
                                else
                                {
                                    MessageBox.Show("No se pueden agregar valores negativos", "No se pudo agregar al carrito");
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("Ese producto ya se encuentra agregado en el carrito ¿Desea modificar su cantidad?", "Producto en el carrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (Convert.ToInt32(cmbCantidad.Text) <= cantidad[1] && Convert.ToInt32(cmbCantidad.Text) >= 1)
                                    {
                                        dv.dgDetalleVenta.Rows[pos].Cells[2].Value = Convert.ToInt32(cmbCantidad.Text);
                                        dv.dgDetalleVenta.Rows[pos].Cells[4].Value = Convert.ToInt32(cmbCantidad.Text) * Convert.ToDecimal(dv.dgDetalleVenta.Rows[pos].Cells[3].Value);
                                    }
                                    else if (Convert.ToInt32(cmbCantidad.Text) == 0)
                                    {

                                        dv.dgDetalleVenta.Rows.Remove(dv.dgDetalleVenta.Rows[pos]);

                                    }
                                    else
                                    {
                                        MessageBox.Show("El Inventario es insuficiente, solo hay " + cantidad[1] + " productos en stock");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Algo Salio Mal. No pudimos procesar su solicitud");
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message); 
                }
            }
            else
            {
                MessageBox.Show("Algo Salio Mal. Lo sentimos");
            }
            connection.Close();
        }
        //Este boton sirve para realizar la busuqeda del producto, si el producto no existe lo notificara, en cambio si lo encontró
        //mostrara la informacion del prodcuto
        private void button3_Click(object sender, EventArgs e)
        {
            string sql;
            cmbCantidad.Items.Clear(); 
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    sql = "Select imagen, nombreProducto, cantidadProducto from Producto where codigoBarra = '" + textBox1.Text + "'";
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        cmd = new SqlCommand(sql, connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();

                        if (reader.HasRows)
                        {
                            existe = true;
                            lblNombre.Text = reader[1].ToString();
                            verificacionNombre = reader[1].ToString();
                            byte[] imag = (byte[])(reader[0]);
                            if (imag == null)
                            {
                                pictureBox1.Image = GerizimZZ.Properties.Resources.Imagen1_PhotoRoom__1_; ;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(imag);
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                            for (int i = 1; i <= Convert.ToInt32(reader["cantidadProducto"]); i++)
                            {
                                cmbCantidad.Items.Add(i); 
                            }
                            cmbCantidad.SelectedIndex = 0; 
                            lblcantidadAAgregar.Visible = true;
                            cmbCantidad.Visible = true; 
                        }
                        else
                        {
                            connection.Close();
                            MessageBox.Show("No existe el producto");
                            pictureBox1.Image = GerizimZZ.Properties.Resources.losentimos;
                            lblNombre.Text = "Producto Inexistente";
                        }
                    }
                }
                catch (Exception ee)
                {
                    Image imagen = GerizimZZ.Properties.Resources.Imagen1_PhotoRoom__1_;
                    pictureBox1.Image = imagen;
                }
            }
            connection.Close();
        }

        private void frCodigoBarra_Load(object sender, EventArgs e)
        {

        }
    }
}
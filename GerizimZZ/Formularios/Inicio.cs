using GerizimZZ.Clases;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace GerizimZZ
{
    public partial class Inicio : Form
    {
        private FlowLayoutPanel flp;

        public Inicio()
        {
            InitializeComponent();

            CollapseMenu();

            Llenado();
        }

        public FlowLayoutPanel FlpDatos { get => flp; set => flp = value; }

        public void IniciarFlowLayout()
        {
            flp = Contenedor;
        }
        //llena el datagrid de productos. 
        public void Llenado()
        {
            Productos llenar = new Productos();
            string consulta = "select * from dbo.Producto where cantidadProducto > 0 order by nombreProducto  ASC ;  ";
            llenar.llenado(Contenedor, consulta);
        }
     
        //toma los valores del carrito y los envia al fomrulario
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraBusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Boton panel lateral derecho
        private void bt_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void btn(object sender, MouseEventArgs e)
        {
        }

        private void btnBodega_Click(object sender, EventArgs e)
        {
        }
        //llama al formulario de bodega
        private void btnBodega_Click_1(object sender, EventArgs e)
        {
            frInicioBodega frInicioBodega = new frInicioBodega();
            AddOwnedForm(frInicioBodega);
            frInicioBodega.Show();
        }

        //click a boton de cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea continuar?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Salida del sistema cancelada");
            }
        }
        //llama al formulario de clientes
        private void btnclientesmi_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.ShowDialog();
        }

        private void btnclientesmi_Hover(object sender, EventArgs e)
        {
            btnclientesmi.BackColor = Color.Cyan;
        }

        private void btnclientesmi_MouseLeaves(object sender, EventArgs e)
        {
            btnclientesmi.BackColor = Color.FromArgb(214, 224, 229);
        }
        //llama al formulario de inventario
        private void btninventariomi_Click(object sender, EventArgs e)
        {
            FrmInventario inventario = new FrmInventario();
            inventario.ShowDialog();
        }

        private void btninventarioomi_Hover(object sender, EventArgs e)
        {
            btninventariomi.BackColor = Color.Cyan;
        }

        private void btninventarioomi_MouseLeaves(object sender, EventArgs e)
        {
            btninventariomi.BackColor = Color.FromArgb(214, 224, 229);
        }

        // click a boton de maximizar
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // click a boton de minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Boton para abrir form de pedido
        private void btnpedidosmi_Click(object sender, EventArgs e)
        {
            frmPantallaPedido frmPantallaPedido = new frmPantallaPedido();
            frmPantallaPedido.ShowDialog();
        }

        private void btnpedidosmi_Hover(object sender, EventArgs e)
        {
            btnpedidosmi.BackColor = Color.Cyan;
        }

        private void btnpedidosmi_MouseLeaves(object sender, EventArgs e)
        {
            btnpedidosmi.BackColor = Color.FromArgb(214, 224, 229);
        }
        //cierra el menu lateral
        private void btnregresarMI_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        //llama al formulario de ventas
        private void btnventasmi_Click(object sender, EventArgs e)
        {
            RegistrosVentas frVentas = new RegistrosVentas();
            AddOwnedForm(frVentas);
            frVentas.Show();
        }
        //Todos los botones funcionan de esta manera. Al pasar sobre ellos se iluminaran con un color cyan
        //al salir de ellos el color volverá a su color natural
        private void btnventasmi_Hover(object sender, EventArgs e)
        {
            btnventasmi.BackColor = Color.Cyan;
        }

        private void btnventasmi_MouseLeaves(object sender, EventArgs e)
        {
            btnventasmi.BackColor = Color.FromArgb(214, 224, 229);
        }
        //Este boton sirve para realizar busquedas de productos. Funciona mediante un query que toma el contenido del textboxt
        // y mediante un query selecciona los productos con ese nombre, codigo. 
        private void button1_Click(object sender, EventArgs e)
        {
            buscar(); 
        }
        //realiza la funcion de busqueda, toma el valor del textbox y lo busca en la base de datos. 
        private void buscar()
        {
            string busqueda;

            Productos pr = new Productos();
            if (!(String.IsNullOrEmpty(this.barraBusqueda.Text)))
            {
                try
                {
                    busqueda = "select * from dbo.Producto where nombreProducto like '%" + barraBusqueda.Text + "%' or codigoBarra like '%" + barraBusqueda.Text + "%' and cantidadProducto >0 order by nombreProducto  ASC; ";
                    SqlConnection conexion = new SqlConnection("Data Source =localhost; Initial Catalog =Gerizim ; Integrated Security = True");
                    Contenedor.Controls.Clear();
                    pr.llenado(Contenedor, busqueda);
                }
                catch (SqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            if ((String.IsNullOrEmpty(this.barraBusqueda.Text)))
            {
                busqueda = "select * from dbo.Producto order by nombreProducto ASC; ";
                Contenedor.Controls.Clear();
                pr.llenado(Contenedor, busqueda);
            }
        }

        //boton lateral derecho menu tipo google
        private void button2_Click(object sender, EventArgs e)
        {
            Barra_preview barra_Preview = new Barra_preview();
            barra_Preview.ShowDialog();
        }

        private void button2_Hover(object sender, EventArgs e)
        {
            this.btnMenuIzquierdo.BackColor = Color.Cyan;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.btnMenuIzquierdo.BackColor = Color.Transparent;
        }
        //llama al fornulario de detalle venta
        private void button3_Click(object sender, EventArgs e)
        {
            DetalleVenta detalleVenta = new DetalleVenta();
            AddOwnedForm(detalleVenta);
            detalleVenta.ShowDialog();
        }

        private void button3_Hover(object sender, EventArgs e)
        {
            this.btnDetalleVenta.BackColor = Color.Cyan;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.btnDetalleVenta.BackColor = Color.Transparent;
        }

        private void CollapseMenu()
        {
            if (this.panelsidemenu.Width > 200)
            {
                panelsidemenu.Width = 0;
                //panelsidemenu.Dock = DockStyle.Left;
                foreach (Button menuButton in panelsidemenu.Controls.OfType<Button>())
                {
                    menuButton.Visible = false;
                }
            }
            else
            {
                panelsidemenu.Width = 240;
                //panelsidemenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelsidemenu.Controls.OfType<Button>())
                {
                    menuButton.Visible = true;
                }
            }
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void panel_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_titlebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelsidemenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void producto1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
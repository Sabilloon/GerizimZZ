using System.Runtime.InteropServices;

namespace GerizimZZ
{
    public partial class frInicioBodega : Form
    {
        public frInicioBodega()
        {
            InitializeComponent();
            CollapseMenu();
        }

        public void Llenado()
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void producto1_Load(object sender, EventArgs e)
        {
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }

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

        private void panel_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_titlebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Barra_preview barra_Preview = new Barra_preview();
            barra_Preview.ShowDialog();
        }

        private void button2_Hover(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Cyan;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Transparent;
        }

        // click a boton de minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        //click a boton de cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Continuar?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
            CollapseMenu();
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

        private void btnregresarMI_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btninventariomi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en la nueva actualizacion", "Muy Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btninventarioomi_Hover(object sender, EventArgs e)
        {
            btninventariomi.BackColor = Color.Cyan;
        }

        private void btninventarioomi_MouseLeaves(object sender, EventArgs e)
        {
            btninventariomi.BackColor = Color.FromArgb(214, 224, 229);
        }

        private void btnclientesmi_Hover(object sender, EventArgs e)
        {
            btnclientesmi.BackColor = Color.Cyan;
        }

        private void btnclientesmi_MouseLeaves(object sender, EventArgs e)
        {
            btnclientesmi.BackColor = Color.FromArgb(214, 224, 229);
        }

        private void btnpedidosmi_Hover(object sender, EventArgs e)
        {
            btnpedidosmi.BackColor = Color.Cyan;
        }

        private void btnpedidosmi_MouseLeaves(object sender, EventArgs e)
        {
            btnpedidosmi.BackColor = Color.FromArgb(214, 224, 229);
        }

        private void btnventasmi_Hover(object sender, EventArgs e)
        {
            btnventasmi.BackColor = Color.Cyan;
        }

        private void btnventasmi_MouseLeaves(object sender, EventArgs e)
        {
            btnventasmi.BackColor = Color.FromArgb(214, 224, 229);
        }

        private void btn(object sender, MouseEventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void BarraBusqueda_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio fr = new Inicio();
            fr.Show();
            this.Close();
        }

        private void button3_Hover(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Cyan;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Transparent;
        }

        //Boton para abrir form de pedido
        private void btnpedidosmi_Click(object sender, EventArgs e)
        {
            frmPantallaPedido frmPantallaPedido = new frmPantallaPedido();
            frmPantallaPedido.ShowDialog();
        }

        private void btnventasmi_Click(object sender, EventArgs e)
        {
            RegistrosVentas bs = new RegistrosVentas();
            bs.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en la nueva actualizacion", "Muy Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnclientesmi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en la nueva actualizacion", "Muy Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en nuevas actualizaciones", "Proximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmSolicitudInventario frmSolicitudInventario = new FrmSolicitudInventario();
            frmSolicitudInventario.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Abrir Pantalla repartidores
            FrmRepartidores repartidores = new FrmRepartidores();
            repartidores.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en nuevas actualizaciones", "Proximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
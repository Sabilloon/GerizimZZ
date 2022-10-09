namespace GerizimZZ
{
    public partial class Barra_preview : Form
    {
        public Barra_preview()
        {
            InitializeComponent();
        }

        private void Barra_preview_Load(object sender, EventArgs e)
        {
        }

        private void btnUsua_Click(object sender, EventArgs e)
        {
            frmUsuario nuevoUsuario = new frmUsuario();
            nuevoUsuario.ShowDialog();
        }

        private void btnUsua_Hover(object sender, EventArgs e)
        {
            this.btnUsua.BackColor = Color.Cyan;
        }

        private void btnUsua_MouseLeave(object sender, EventArgs e)
        {
            this.btnUsua.BackColor = Color.Transparent;
        }

        private void btnHisto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en la nueva actualizacion", "Muy Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHisto_Hover(object sender, EventArgs e)
        {
            this.btnHisto.BackColor = Color.Cyan;
        }

        private void btnHisto_MouseLeave(object sender, EventArgs e)
        {
            this.btnHisto.BackColor = Color.Transparent;
        }

        private void btnOpcio_Click(object sender, EventArgs e)
        {
            Opciones opciones = new Opciones();
            opciones.ShowDialog();
        }

        private void btnOpcio_Hover(object sender, EventArgs e)
        {
            this.btnOpcio.BackColor = Color.Cyan;
        }

        private void btnOpcio_MouseLeave(object sender, EventArgs e)
        {
            this.btnOpcio.BackColor = Color.Transparent;
        }

        private void btnRepor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en la nueva actualizacion", "Muy Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRepor_Hover(object sender, EventArgs e)
        {
            this.btnRepor.BackColor = Color.Cyan;
        }

        private void btnRepor_MouseLeave(object sender, EventArgs e)
        {
            this.btnRepor.BackColor = Color.Transparent;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El sistema no tiene actualizaciones pendientes", "Sistema Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Hover(object sender, EventArgs e)
        {
            this.btnUpdate.BackColor = Color.Cyan;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            this.btnUpdate.BackColor = Color.Transparent;
        }

        private void btnAviso_Click(object sender, EventArgs e)
        {
            frmAvisos aviso = new frmAvisos();

            aviso.Show();
        }

        private void btnAviso_Hover(object sender, EventArgs e)
        {
            this.btnAviso.BackColor = Color.Cyan;
        }

        private void btnAviso_MouseLeave(object sender, EventArgs e)
        {
            this.btnAviso.BackColor = Color.Transparent;
        }

        //click a boton de regresar
        private void btncerrarBP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
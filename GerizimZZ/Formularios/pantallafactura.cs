using GerizimZZ.Clases;

namespace GerizimZZ
{
    public partial class pantallafactura : Form
    {
        public pantallafactura()
        {
            InitializeComponent();
        }

        private conexionfactura cme = new conexionfactura();

        private void pantallafactura_Load(object sender, EventArgs e)
        {
            //Lennar datagrid llamando a la clase
            cme.datosgrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LLenar Textbox con datos del grid
            insucursal.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            incliente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            infecha.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            id.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            indetalle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            intotal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void id_Click(object sender, EventArgs e)
        {
        }

        private void infecha_TextChanged(object sender, EventArgs e)
        {
        }

        private void intotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
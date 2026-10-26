namespace AppWinForms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void productoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FormProductores form = new FormProductores();
            form.ShowDialog();
        }

        private void cerealesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FormCereales form = new FormCereales();
            form.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FormClientes form = new FormClientes();
            form.ShowDialog();
        }

        private void descargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FormDescargas form = new FormDescargas();
            form.ShowDialog();
        }

        private void despachosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FormDespachos form = new FormDespachos();
            form.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FormReportes form = new FormReportes();
            form.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

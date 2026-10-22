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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

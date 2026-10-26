using Microsoft.Extensions.DependencyInjection;

namespace AppWinForms
{
    public partial class FormPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public FormPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void AbrirFormulario<T>() where T : Form
        {
            using IServiceScope scope = _serviceProvider
                .CreateScope();
            T form = scope.ServiceProvider
                .GetRequiredService<T>();
            form
                .ShowDialog();
        }

        private void productoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProductores>();
        }

        private void cerealesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCereales>();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormClientes>();
        }

        private void descargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormDescargas>();
        }

        private void despachosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormDespachos>();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormReportes>();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

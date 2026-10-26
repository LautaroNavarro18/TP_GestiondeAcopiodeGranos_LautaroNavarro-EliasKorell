using AccesoDatos.Entidades;
using AccesoDatos.Repositorios;

namespace AppWinForms
{
    public partial class FormClientes : Form
    {
        private readonly IClienteRepositorio _repositorio;

        private int _idSeleccionado = 0;

        public FormClientes(IClienteRepositorio repositorio)
        {
            InitializeComponent();
            _repositorio = repositorio;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgvClientes.DataSource = _repositorio.ObtenerTodos();
            dgvClientes.Columns["Activo"].Visible = false;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            _idSeleccionado = 0;
            txtNombre.Clear();
            txtCuit.Clear();
            txtTelefono.Clear();
            txtLocalidad.Clear();
            dgvClientes.ClearSelection();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null || !dgvClientes.CurrentRow.Selected)
                return;

            Cliente cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            _idSeleccionado = cliente.Id;
            txtNombre.Text = cliente.Nombre;
            txtCuit.Text = cliente.Cuit;
            txtTelefono.Text = cliente.Telefono;
            txtLocalidad.Text = cliente.Localidad;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                MessageBox.Show("El nombre y el CUIT son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = new Cliente
            {
                Id = _idSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Cuit = txtCuit.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Localidad = txtLocalidad.Text.Trim()
            };

            if (_idSeleccionado == 0)
                _repositorio.Agregar(cliente);
            else
                _repositorio.Modificar(cliente);

            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea dar de baja al cliente seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                _repositorio.Eliminar(_idSeleccionado);
                CargarGrilla();
            }
        }
    }
}

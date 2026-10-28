using AccesoDatos.Entidades;
using AccesoDatos.Repositorios;

namespace AppWinForms
{
    public partial class FormProductores : Form
    {
        private readonly IProductorRepositorio _repositorio;

        private int _idSeleccionado = 0;

        public FormProductores(IProductorRepositorio repositorio)
        {
            InitializeComponent();
            _repositorio = repositorio;
        }

        private void FormProductores_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgvProductores.DataSource = _repositorio.ObtenerTodos();
            dgvProductores.Columns["Activo"].Visible = false;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            _idSeleccionado = 0;
            txtNombre.Clear();
            txtCuit.Clear();
            txtTelefono.Clear();
            txtLocalidad.Clear();
            dgvProductores.ClearSelection();
        }

        private void dgvProductores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductores.CurrentRow == null || !dgvProductores.CurrentRow.Selected)
                return;

            Productor productor = (Productor)dgvProductores.CurrentRow.DataBoundItem;
            _idSeleccionado = productor.Id;
            txtNombre.Text = productor.Nombre;
            txtCuit.Text = productor.Cuit;
            txtTelefono.Text = productor.Telefono;
            txtLocalidad.Text = productor.Localidad;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos())
                return;

            string cuitFormateado = Validaciones
                .FormatearCuit(txtCuit.Text.Trim());

            if (_repositorio.ExisteCuit(cuitFormateado, _idSeleccionado))
            {
                Validaciones.Aviso("Ya existe un productor con ese CUIT.");
                txtCuit.Focus();
                return;
            }

            Productor productor = new Productor
            {
                Id = _idSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Cuit = cuitFormateado,
                Telefono = txtTelefono.Text.Trim(),
                Localidad = txtLocalidad.Text.Trim()
            };

            if (_idSeleccionado == 0)
                _repositorio.Agregar(productor);
            else
                _repositorio.Modificar(productor);

            CargarGrilla();
        }

        private bool DatosValidos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text.Trim().Length < 3)
            {
                Validaciones.Aviso("El nombre es obligatorio y debe tener al menos 3 caracteres.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                Validaciones.Aviso("El CUIT es obligatorio.");
                txtCuit.Focus();
                return false;
            }

            if (!Validaciones.CuitValido(txtCuit.Text.Trim()))
            {
                Validaciones.Aviso("El CUIT ingresado no es válido.");
                txtCuit.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !Validaciones.TelefonoValido(txtTelefono.Text.Trim()))
            {
                Validaciones.Aviso("El teléfono ingresado no es válido.");
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocalidad.Text))
            {
                Validaciones.Aviso("La localidad es obligatoria.");
                txtLocalidad.Focus();
                return false;
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un productor de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea dar de baja al productor seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                _repositorio.Eliminar(_idSeleccionado);
                CargarGrilla();
            }
        }
    }
}

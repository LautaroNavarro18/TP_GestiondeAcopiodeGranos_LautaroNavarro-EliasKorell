using AccesoDatos.Entidades;
using AccesoDatos.Repositorios;

namespace AppWinForms
{
    public partial class FormCereales : Form
    {
        private readonly ICerealRepositorio _repositorio = new CerealRepositorio();

        private int _idSeleccionado = 0;

        public FormCereales()
        {
            InitializeComponent();
        }

        private void FormCereales_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgvCereales.DataSource = _repositorio.ObtenerTodos();
            dgvCereales.Columns["Activo"].Visible = false;
            dgvCereales.Columns["HumedadMaxima"].HeaderText = "Humedad máxima (%)";
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            _idSeleccionado = 0;
            txtNombre.Clear();
            nudHumedadMaxima.Value = 0;
            dgvCereales.ClearSelection();
        }

        private void dgvCereales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCereales.CurrentRow == null || !dgvCereales.CurrentRow.Selected)
                return;

            Cereal cereal = (Cereal)dgvCereales.CurrentRow.DataBoundItem;
            _idSeleccionado = cereal.Id;
            txtNombre.Text = cereal.Nombre;
            nudHumedadMaxima.Value = (decimal)cereal.HumedadMaxima;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudHumedadMaxima.Value <= 0)
            {
                MessageBox.Show("La humedad máxima debe ser mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cereal cereal = new Cereal
            {
                Id = _idSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                HumedadMaxima = (double)nudHumedadMaxima.Value
            };

            if (_idSeleccionado == 0)
                _repositorio.Agregar(cereal);
            else
                _repositorio.Modificar(cereal);

            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cereal de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea dar de baja el cereal seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                _repositorio.Eliminar(_idSeleccionado);
                CargarGrilla();
            }
        }
    }
}

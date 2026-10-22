using AccesoDatos.Entidades;
using AccesoDatos.Repositorios;

namespace AppWinForms
{
    public partial class FormDescargas : Form
    {
        private readonly IDescargaRepositorio _repositorio = new DescargaRepositorio();
        private readonly IProductorRepositorio _productorRepositorio = new ProductorRepositorio();
        private readonly ICerealRepositorio _cerealRepositorio = new CerealRepositorio();

        private List<Descarga> _descargas = new List<Descarga>();
        private int _idSeleccionado = 0;

        public FormDescargas()
        {
            InitializeComponent();
        }

        private void FormDescargas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarGrilla();
        }

        private void CargarCombos()
        {
            cmbProductor.DisplayMember = "Nombre";
            cmbProductor.ValueMember = "Id";
            cmbProductor.DataSource = _productorRepositorio.ObtenerTodos();

            cmbCereal.DisplayMember = "Nombre";
            cmbCereal.ValueMember = "Id";
            cmbCereal.DataSource = _cerealRepositorio.ObtenerTodos();
        }

        private void CargarGrilla()
        {
            _descargas = _repositorio.ObtenerTodos();
            dgvDescargas.DataSource = _descargas
                .Select(d => new
                {
                    d.Id,
                    d.Fecha,
                    Productor = d.Productor.Nombre,
                    Cereal = d.Cereal.Nombre,
                    d.Patente,
                    d.KilosBrutos,
                    d.Tara,
                    KilosNetos = d.KilosNetos(),
                    d.Humedad,
                    d.Estado
                })
                .ToList();
            dgvDescargas.Columns["Id"].Visible = false;
            dgvDescargas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDescargas.Columns["KilosBrutos"].HeaderText = "Kilos brutos";
            dgvDescargas.Columns["KilosNetos"].HeaderText = "Kilos netos";
            dgvDescargas.Columns["Humedad"].HeaderText = "Humedad (%)";
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            _idSeleccionado = 0;
            dtpFecha.Value = DateTime.Today;
            cmbProductor.SelectedIndex = -1;
            cmbCereal.SelectedIndex = -1;
            txtPatente.Clear();
            nudKilosBrutos.Value = 0;
            nudTara.Value = 0;
            nudHumedad.Value = 0;
            dgvDescargas.ClearSelection();
            ActualizarEstado();
        }

        private void dgvDescargas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDescargas.CurrentRow == null || !dgvDescargas.CurrentRow.Selected)
                return;

            int id = (int)dgvDescargas.CurrentRow.Cells["Id"].Value;
            Descarga descarga = _descargas.First(d => d.Id == id);
            _idSeleccionado = descarga.Id;
            dtpFecha.Value = descarga.Fecha;
            cmbProductor.SelectedValue = descarga.ProductorId;
            cmbCereal.SelectedValue = descarga.CerealId;
            txtPatente.Text = descarga.Patente;
            nudKilosBrutos.Value = descarga.KilosBrutos;
            nudTara.Value = descarga.Tara;
            nudHumedad.Value = (decimal)descarga.Humedad;
            ActualizarEstado();
        }

        private void cmbCereal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEstado();
        }

        private void nudHumedad_ValueChanged(object sender, EventArgs e)
        {
            ActualizarEstado();
        }

        private void ActualizarEstado()
        {
            if (cmbCereal.SelectedItem is not Cereal cereal)
            {
                lblEstado.Text = "Estado: -";
                return;
            }

            Descarga descarga = new Descarga { Humedad = (double)nudHumedad.Value };
            descarga.DeterminarEstado(cereal.HumedadMaxima);
            lblEstado.Text = $"Estado: {descarga.Estado} (máx. {cereal.HumedadMaxima}%)";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            cmbProductor.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbProductor.SelectedValue == null || cmbCereal.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el productor y el cereal.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPatente.Text))
            {
                MessageBox.Show("La patente es obligatoria.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudTara.Value >= nudKilosBrutos.Value)
            {
                MessageBox.Show("Los kilos brutos deben ser mayores a la tara.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Descarga descarga = new Descarga
            {
                Id = _idSeleccionado,
                Fecha = dtpFecha.Value.Date,
                ProductorId = (int)cmbProductor.SelectedValue,
                CerealId = (int)cmbCereal.SelectedValue,
                Patente = txtPatente.Text.Trim().ToUpper(),
                KilosBrutos = (int)nudKilosBrutos.Value,
                Tara = (int)nudTara.Value,
                Humedad = (double)nudHumedad.Value
            };

            try
            {
                if (_idSeleccionado == 0)
                    _repositorio.Agregar(descarga);
                else
                    _repositorio.Modificar(descarga);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una descarga de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea eliminar la descarga seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    _repositorio.Eliminar(_idSeleccionado);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CargarGrilla();
            }
        }
    }
}

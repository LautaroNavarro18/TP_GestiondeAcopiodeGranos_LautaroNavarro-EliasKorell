using AccesoDatos.Entidades;
using AccesoDatos.Repositorios;

namespace AppWinForms
{
    public partial class FormDespachos : Form
    {
        private readonly IDespachoRepositorio _repositorio;
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly ICerealRepositorio _cerealRepositorio;

        private List<Despacho> _despachos = new List<Despacho>();
        private int _idSeleccionado = 0;

        public FormDespachos(IDespachoRepositorio repositorio, IClienteRepositorio clienteRepositorio, ICerealRepositorio cerealRepositorio)
        {
            InitializeComponent();
            _repositorio = repositorio;
            _clienteRepositorio = clienteRepositorio;
            _cerealRepositorio = cerealRepositorio;
        }

        private void FormDespachos_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarGrilla();
        }

        private void CargarCombos()
        {
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DataSource = _clienteRepositorio.ObtenerTodos();

            cmbCereal.DisplayMember = "Nombre";
            cmbCereal.ValueMember = "Id";
            cmbCereal.DataSource = _cerealRepositorio.ObtenerTodos();
        }

        private void CargarGrilla()
        {
            _despachos = _repositorio.ObtenerTodos();
            dgvDespachos.DataSource = _despachos
                .Select(d => new
                {
                    d.Id,
                    d.Fecha,
                    Cliente = d.Cliente.Nombre,
                    Cereal = d.Cereal.Nombre,
                    d.Patente,
                    d.KilosBrutos,
                    d.Tara,
                    KilosNetos = d.KilosNetos()
                })
                .ToList();
            dgvDespachos.Columns["Id"].Visible = false;
            dgvDespachos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDespachos.Columns["KilosBrutos"].HeaderText = "Kilos brutos";
            dgvDespachos.Columns["KilosNetos"].HeaderText = "Kilos netos";
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            _idSeleccionado = 0;
            dtpFecha.Value = DateTime.Today;
            cmbCliente.SelectedIndex = -1;
            cmbCereal.SelectedIndex = -1;
            txtPatente.Clear();
            nudKilosBrutos.Value = 0;
            nudTara.Value = 0;
            dgvDespachos.ClearSelection();
            ActualizarStock();
        }

        private void dgvDespachos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDespachos.CurrentRow == null || !dgvDespachos.CurrentRow.Selected)
                return;

            int id = (int)dgvDespachos.CurrentRow.Cells["Id"].Value;
            Despacho despacho = _despachos.First(d => d.Id == id);
            _idSeleccionado = despacho.Id;
            dtpFecha.Value = despacho.Fecha;
            cmbCliente.SelectedValue = despacho.ClienteId;
            cmbCereal.SelectedValue = despacho.CerealId;
            txtPatente.Text = despacho.Patente;
            nudKilosBrutos.Value = despacho.KilosBrutos;
            nudTara.Value = despacho.Tara;
            ActualizarStock();
        }

        private void cmbCereal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarStock();
        }

        private void ActualizarStock()
        {
            if (cmbCereal.SelectedItem is not Cereal cereal)
            {
                lblStock.Text = "Stock disponible: -";
                return;
            }

            int stock = _cerealRepositorio.StockDisponible(cereal.Id);
            lblStock.Text = $"Stock disponible: {stock:N0} kg";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            cmbCliente.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null || cmbCereal.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el cliente y el cereal.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            Despacho despacho = new Despacho
            {
                Id = _idSeleccionado,
                Fecha = dtpFecha.Value.Date,
                ClienteId = (int)cmbCliente.SelectedValue,
                CerealId = (int)cmbCereal.SelectedValue,
                Patente = txtPatente.Text.Trim().ToUpper(),
                KilosBrutos = (int)nudKilosBrutos.Value,
                Tara = (int)nudTara.Value
            };

            try
            {
                if (_idSeleccionado == 0)
                    _repositorio.Agregar(despacho);
                else
                    _repositorio.Modificar(despacho);
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
                MessageBox.Show("Seleccione un despacho de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea eliminar el despacho seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                _repositorio.Eliminar(_idSeleccionado);
                CargarGrilla();
            }
        }
    }
}

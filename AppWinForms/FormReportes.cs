using AccesoDatos.Repositorios;

namespace AppWinForms
{
    public partial class FormReportes : Form
    {
        private readonly IReporteRepositorio _repositorio;
        private readonly IProductorRepositorio _productorRepositorio;

        private const int ReporteHistorial = 4;

        public FormReportes(IReporteRepositorio repositorio, IProductorRepositorio productorRepositorio)
        {
            InitializeComponent();
            _repositorio = repositorio;
            _productorRepositorio = productorRepositorio;
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            cmbProductor.DisplayMember = "Nombre";
            cmbProductor.ValueMember = "Id";
            cmbProductor.DataSource = _productorRepositorio.ObtenerTodos();
            cmbProductor.SelectedIndex = -1;

            cmbReporte.Items.AddRange(new object[]
            {
                "Ranking de productores por kilos entregados",
                "Total de kilos recibidos por cereal",
                "Cantidad de descargas por mes",
                "Descargas rechazadas por exceso de humedad",
                "Historial de descargas de un productor",
                "Despachos realizados",
                "Total de kilos despachados por cliente"
            });
            cmbReporte.SelectedIndex = 0;
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esHistorial = cmbReporte.SelectedIndex == ReporteHistorial;
            lblProductor.Visible = esHistorial;
            cmbProductor.Visible = esHistorial;
            CargarReporte();
        }

        private void cmbProductor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReporte.SelectedIndex == ReporteHistorial)
                CargarReporte();
        }

        private void CargarReporte()
        {
            switch (cmbReporte.SelectedIndex)
            {
                case 0:
                    dgvReporte.DataSource = _repositorio.RankingProductores();
                    break;
                case 1:
                    dgvReporte.DataSource = _repositorio.KilosRecibidosPorCereal();
                    break;
                case 2:
                    dgvReporte.DataSource = _repositorio.DescargasPorMes();
                    break;
                case 3:
                    dgvReporte.DataSource = _repositorio.DescargasRechazadas();
                    break;
                case ReporteHistorial:
                    if (cmbProductor.SelectedValue is int productorId)
                        dgvReporte.DataSource = _repositorio.HistorialProductor(productorId);
                    else
                        dgvReporte.DataSource = null;
                    break;
                case 5:
                    dgvReporte.DataSource = _repositorio.DespachosRealizados();
                    break;
                case 6:
                    dgvReporte.DataSource = _repositorio.KilosDespachadosPorCliente();
                    break;
            }

            FormatearColumnas();
        }

        private void FormatearColumnas()
        {
            foreach (DataGridViewColumn columna in dgvReporte.Columns)
            {
                switch (columna.Name)
                {
                    case "Fecha":
                        columna.DefaultCellStyle.Format = "dd/MM/yyyy";
                        break;
                    case "KilosNetos":
                        columna.HeaderText = "Kilos netos";
                        columna.DefaultCellStyle.Format = "N0";
                        break;
                    case "Humedad":
                        columna.HeaderText = "Humedad (%)";
                        break;
                    case "HumedadMaxima":
                        columna.HeaderText = "Humedad máxima (%)";
                        break;
                }
            }
        }
    }
}

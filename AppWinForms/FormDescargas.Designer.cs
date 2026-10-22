namespace AppWinForms
{
    partial class FormDescargas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvDescargas = new DataGridView();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblProductor = new Label();
            cmbProductor = new ComboBox();
            lblCereal = new Label();
            cmbCereal = new ComboBox();
            lblPatente = new Label();
            txtPatente = new TextBox();
            lblKilosBrutos = new Label();
            nudKilosBrutos = new NumericUpDown();
            lblTara = new Label();
            nudTara = new NumericUpDown();
            lblHumedad = new Label();
            nudHumedad = new NumericUpDown();
            lblEstado = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDescargas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilosBrutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTara).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHumedad).BeginInit();
            SuspendLayout();
            dgvDescargas.AllowUserToAddRows = false;
            dgvDescargas.AllowUserToDeleteRows = false;
            dgvDescargas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDescargas.Location = new Point(12, 12);
            dgvDescargas.MultiSelect = false;
            dgvDescargas.Name = "dgvDescargas";
            dgvDescargas.ReadOnly = true;
            dgvDescargas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDescargas.Size = new Size(700, 616);
            dgvDescargas.TabIndex = 0;
            dgvDescargas.SelectionChanged += dgvDescargas_SelectionChanged;
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(730, 12);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(730, 35);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(258, 27);
            dtpFecha.TabIndex = 2;
            lblProductor.AutoSize = true;
            lblProductor.Location = new Point(730, 72);
            lblProductor.Name = "lblProductor";
            lblProductor.Size = new Size(74, 20);
            lblProductor.TabIndex = 3;
            lblProductor.Text = "Productor";
            cmbProductor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductor.Location = new Point(730, 95);
            cmbProductor.Name = "cmbProductor";
            cmbProductor.Size = new Size(258, 28);
            cmbProductor.TabIndex = 4;
            lblCereal.AutoSize = true;
            lblCereal.Location = new Point(730, 132);
            lblCereal.Name = "lblCereal";
            lblCereal.Size = new Size(50, 20);
            lblCereal.TabIndex = 5;
            lblCereal.Text = "Cereal";
            cmbCereal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCereal.Location = new Point(730, 155);
            cmbCereal.Name = "cmbCereal";
            cmbCereal.Size = new Size(258, 28);
            cmbCereal.TabIndex = 6;
            cmbCereal.SelectedIndexChanged += cmbCereal_SelectedIndexChanged;
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(730, 192);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(59, 20);
            lblPatente.TabIndex = 7;
            lblPatente.Text = "Patente";
            txtPatente.CharacterCasing = CharacterCasing.Upper;
            txtPatente.Location = new Point(730, 215);
            txtPatente.MaxLength = 10;
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(258, 27);
            txtPatente.TabIndex = 8;
            lblKilosBrutos.AutoSize = true;
            lblKilosBrutos.Location = new Point(730, 252);
            lblKilosBrutos.Name = "lblKilosBrutos";
            lblKilosBrutos.Size = new Size(88, 20);
            lblKilosBrutos.TabIndex = 9;
            lblKilosBrutos.Text = "Kilos brutos";
            nudKilosBrutos.Location = new Point(730, 275);
            nudKilosBrutos.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudKilosBrutos.Name = "nudKilosBrutos";
            nudKilosBrutos.Size = new Size(258, 27);
            nudKilosBrutos.TabIndex = 10;
            nudKilosBrutos.ThousandsSeparator = true;
            lblTara.AutoSize = true;
            lblTara.Location = new Point(730, 312);
            lblTara.Name = "lblTara";
            lblTara.Size = new Size(38, 20);
            lblTara.TabIndex = 11;
            lblTara.Text = "Tara";
            nudTara.Location = new Point(730, 335);
            nudTara.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudTara.Name = "nudTara";
            nudTara.Size = new Size(258, 27);
            nudTara.TabIndex = 12;
            nudTara.ThousandsSeparator = true;
            lblHumedad.AutoSize = true;
            lblHumedad.Location = new Point(730, 372);
            lblHumedad.Name = "lblHumedad";
            lblHumedad.Size = new Size(99, 20);
            lblHumedad.TabIndex = 13;
            lblHumedad.Text = "Humedad (%)";
            nudHumedad.DecimalPlaces = 1;
            nudHumedad.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudHumedad.Location = new Point(730, 395);
            nudHumedad.Name = "nudHumedad";
            nudHumedad.Size = new Size(258, 27);
            nudHumedad.TabIndex = 14;
            nudHumedad.ValueChanged += nudHumedad_ValueChanged;
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstado.Location = new Point(730, 435);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(72, 20);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado: -";
            btnNuevo.Location = new Point(730, 475);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(258, 35);
            btnNuevo.TabIndex = 16;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            btnGuardar.Location = new Point(730, 516);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(258, 35);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            btnEliminar.Location = new Point(730, 557);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(258, 35);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 640);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(lblEstado);
            Controls.Add(nudHumedad);
            Controls.Add(lblHumedad);
            Controls.Add(nudTara);
            Controls.Add(lblTara);
            Controls.Add(nudKilosBrutos);
            Controls.Add(lblKilosBrutos);
            Controls.Add(txtPatente);
            Controls.Add(lblPatente);
            Controls.Add(cmbCereal);
            Controls.Add(lblCereal);
            Controls.Add(cmbProductor);
            Controls.Add(lblProductor);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(dgvDescargas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDescargas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Descargas";
            Load += FormDescargas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDescargas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilosBrutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTara).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHumedad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDescargas;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblProductor;
        private ComboBox cmbProductor;
        private Label lblCereal;
        private ComboBox cmbCereal;
        private Label lblPatente;
        private TextBox txtPatente;
        private Label lblKilosBrutos;
        private NumericUpDown nudKilosBrutos;
        private Label lblTara;
        private NumericUpDown nudTara;
        private Label lblHumedad;
        private NumericUpDown nudHumedad;
        private Label lblEstado;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}

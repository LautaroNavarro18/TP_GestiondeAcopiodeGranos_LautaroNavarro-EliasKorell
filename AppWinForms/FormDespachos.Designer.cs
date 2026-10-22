namespace AppWinForms
{
    partial class FormDespachos
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
            dgvDespachos = new DataGridView();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            lblCereal = new Label();
            cmbCereal = new ComboBox();
            lblPatente = new Label();
            txtPatente = new TextBox();
            lblKilosBrutos = new Label();
            nudKilosBrutos = new NumericUpDown();
            lblTara = new Label();
            nudTara = new NumericUpDown();
            lblStock = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDespachos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilosBrutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTara).BeginInit();
            SuspendLayout();
            dgvDespachos.AllowUserToAddRows = false;
            dgvDespachos.AllowUserToDeleteRows = false;
            dgvDespachos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDespachos.Location = new Point(12, 12);
            dgvDespachos.MultiSelect = false;
            dgvDespachos.Name = "dgvDespachos";
            dgvDespachos.ReadOnly = true;
            dgvDespachos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDespachos.Size = new Size(700, 556);
            dgvDespachos.TabIndex = 0;
            dgvDespachos.SelectionChanged += dgvDespachos_SelectionChanged;
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
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(730, 72);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente";
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Location = new Point(730, 95);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(258, 28);
            cmbCliente.TabIndex = 4;
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
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.Location = new Point(730, 375);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(140, 20);
            lblStock.TabIndex = 13;
            lblStock.Text = "Stock disponible: -";
            btnNuevo.Location = new Point(730, 415);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(258, 35);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            btnGuardar.Location = new Point(730, 456);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(258, 35);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            btnEliminar.Location = new Point(730, 497);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(258, 35);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 580);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(lblStock);
            Controls.Add(nudTara);
            Controls.Add(lblTara);
            Controls.Add(nudKilosBrutos);
            Controls.Add(lblKilosBrutos);
            Controls.Add(txtPatente);
            Controls.Add(lblPatente);
            Controls.Add(cmbCereal);
            Controls.Add(lblCereal);
            Controls.Add(cmbCliente);
            Controls.Add(lblCliente);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(dgvDespachos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDespachos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Despachos";
            Load += FormDespachos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDespachos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilosBrutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTara).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDespachos;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblCliente;
        private ComboBox cmbCliente;
        private Label lblCereal;
        private ComboBox cmbCereal;
        private Label lblPatente;
        private TextBox txtPatente;
        private Label lblKilosBrutos;
        private NumericUpDown nudKilosBrutos;
        private Label lblTara;
        private NumericUpDown nudTara;
        private Label lblStock;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}

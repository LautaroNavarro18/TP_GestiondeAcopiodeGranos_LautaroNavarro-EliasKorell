namespace AppWinForms
{
    partial class FormCereales
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
            dgvCereales = new DataGridView();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblHumedadMaxima = new Label();
            nudHumedadMaxima = new NumericUpDown();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCereales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHumedadMaxima).BeginInit();
            SuspendLayout();
            dgvCereales.AllowUserToAddRows = false;
            dgvCereales.AllowUserToDeleteRows = false;
            dgvCereales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCereales.Location = new Point(12, 12);
            dgvCereales.MultiSelect = false;
            dgvCereales.Name = "dgvCereales";
            dgvCereales.ReadOnly = true;
            dgvCereales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCereales.Size = new Size(520, 426);
            dgvCereales.TabIndex = 0;
            dgvCereales.SelectionChanged += dgvCereales_SelectionChanged;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(550, 12);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            txtNombre.Location = new Point(550, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 27);
            txtNombre.TabIndex = 2;
            lblHumedadMaxima.AutoSize = true;
            lblHumedadMaxima.Location = new Point(550, 72);
            lblHumedadMaxima.Name = "lblHumedadMaxima";
            lblHumedadMaxima.Size = new Size(155, 20);
            lblHumedadMaxima.TabIndex = 3;
            lblHumedadMaxima.Text = "Humedad máxima (%)";
            nudHumedadMaxima.DecimalPlaces = 1;
            nudHumedadMaxima.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudHumedadMaxima.Location = new Point(550, 95);
            nudHumedadMaxima.Name = "nudHumedadMaxima";
            nudHumedadMaxima.Size = new Size(238, 27);
            nudHumedadMaxima.TabIndex = 4;
            btnNuevo.Location = new Point(550, 145);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(238, 35);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            btnGuardar.Location = new Point(550, 186);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(238, 35);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            btnEliminar.Location = new Point(550, 227);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(238, 35);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(nudHumedadMaxima);
            Controls.Add(lblHumedadMaxima);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(dgvCereales);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCereales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Cereales";
            Load += FormCereales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCereales).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHumedadMaxima).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCereales;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblHumedadMaxima;
        private NumericUpDown nudHumedadMaxima;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}

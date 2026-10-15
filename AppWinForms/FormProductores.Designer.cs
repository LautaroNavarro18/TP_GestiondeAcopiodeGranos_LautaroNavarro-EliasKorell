namespace AppWinForms
{
    partial class FormProductores
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
            dgvProductores = new DataGridView();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCuit = new Label();
            txtCuit = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblLocalidad = new Label();
            txtLocalidad = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductores).BeginInit();
            SuspendLayout();
            dgvProductores.AllowUserToAddRows = false;
            dgvProductores.AllowUserToDeleteRows = false;
            dgvProductores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductores.Location = new Point(12, 12);
            dgvProductores.MultiSelect = false;
            dgvProductores.Name = "dgvProductores";
            dgvProductores.ReadOnly = true;
            dgvProductores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductores.Size = new Size(520, 426);
            dgvProductores.TabIndex = 0;
            dgvProductores.SelectionChanged += dgvProductores_SelectionChanged;
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
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(550, 72);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(39, 20);
            lblCuit.TabIndex = 3;
            lblCuit.Text = "CUIT";
            txtCuit.Location = new Point(550, 95);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(238, 27);
            txtCuit.TabIndex = 4;
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(550, 132);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono";
            txtTelefono.Location = new Point(550, 155);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(238, 27);
            txtTelefono.TabIndex = 6;
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(550, 192);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(74, 20);
            lblLocalidad.TabIndex = 7;
            lblLocalidad.Text = "Localidad";
            txtLocalidad.Location = new Point(550, 215);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(238, 27);
            txtLocalidad.TabIndex = 8;
            btnNuevo.Location = new Point(550, 265);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(238, 35);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            btnGuardar.Location = new Point(550, 306);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(238, 35);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            btnEliminar.Location = new Point(550, 347);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(238, 35);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtLocalidad);
            Controls.Add(lblLocalidad);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtCuit);
            Controls.Add(lblCuit);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(dgvProductores);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormProductores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Productores";
            Load += FormProductores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductores;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCuit;
        private TextBox txtCuit;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblLocalidad;
        private TextBox txtLocalidad;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}

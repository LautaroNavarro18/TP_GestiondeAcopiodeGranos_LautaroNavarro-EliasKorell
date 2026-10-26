namespace AppWinForms
{
    partial class FormReportes
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
            lblReporte = new Label();
            cmbReporte = new ComboBox();
            lblProductor = new Label();
            cmbProductor = new ComboBox();
            dgvReporte = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            lblReporte.AutoSize = true;
            lblReporte.Location = new Point(12, 12);
            lblReporte.Name = "lblReporte";
            lblReporte.Size = new Size(61, 20);
            lblReporte.TabIndex = 0;
            lblReporte.Text = "Reporte";
            cmbReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReporte.Location = new Point(12, 35);
            cmbReporte.Name = "cmbReporte";
            cmbReporte.Size = new Size(420, 28);
            cmbReporte.TabIndex = 1;
            cmbReporte.SelectedIndexChanged += cmbReporte_SelectedIndexChanged;
            lblProductor.AutoSize = true;
            lblProductor.Location = new Point(450, 12);
            lblProductor.Name = "lblProductor";
            lblProductor.Size = new Size(74, 20);
            lblProductor.TabIndex = 2;
            lblProductor.Text = "Productor";
            lblProductor.Visible = false;
            cmbProductor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductor.Location = new Point(450, 35);
            cmbProductor.Name = "cmbProductor";
            cmbProductor.Size = new Size(300, 28);
            cmbProductor.TabIndex = 3;
            cmbProductor.Visible = false;
            cmbProductor.SelectedIndexChanged += cmbProductor_SelectedIndexChanged;
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.Location = new Point(12, 80);
            dgvReporte.MultiSelect = false;
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(976, 508);
            dgvReporte.TabIndex = 4;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(dgvReporte);
            Controls.Add(cmbProductor);
            Controls.Add(lblProductor);
            Controls.Add(cmbReporte);
            Controls.Add(lblReporte);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            Load += FormReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReporte;
        private ComboBox cmbReporte;
        private Label lblProductor;
        private ComboBox cmbProductor;
        private DataGridView dgvReporte;
    }
}

namespace AppWinForms
{
    partial class FormPrincipal
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
            menuPrincipal = new MenuStrip();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            productoresToolStripMenuItem = new ToolStripMenuItem();
            cerealesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            menuPrincipal.ImageScalingSize = new Size(20, 20);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { gestionToolStripMenuItem, salirToolStripMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(800, 28);
            menuPrincipal.TabIndex = 0;
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productoresToolStripMenuItem, cerealesToolStripMenuItem });
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(74, 24);
            gestionToolStripMenuItem.Text = "Gestión";
            productoresToolStripMenuItem.Name = "productoresToolStripMenuItem";
            productoresToolStripMenuItem.Size = new Size(224, 26);
            productoresToolStripMenuItem.Text = "Productores";
            productoresToolStripMenuItem.Click += productoresToolStripMenuItem_Click;
            cerealesToolStripMenuItem.Name = "cerealesToolStripMenuItem";
            cerealesToolStripMenuItem.Size = new Size(224, 26);
            cerealesToolStripMenuItem.Text = "Cereales";
            cerealesToolStripMenuItem.Click += cerealesToolStripMenuItem_Click;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuPrincipal);
            MainMenuStrip = menuPrincipal;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Acopio de Granos";
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem productoresToolStripMenuItem;
        private ToolStripMenuItem cerealesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}

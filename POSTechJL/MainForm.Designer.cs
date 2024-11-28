namespace POSTechJL
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            this.btnAdminData = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnAdminData (Administración de Datos)
            this.btnAdminData.Location = new System.Drawing.Point(50, 50);
            this.btnAdminData.Name = "btnAdminData";
            this.btnAdminData.Size = new System.Drawing.Size(120, 40);
            this.btnAdminData.TabIndex = 0;
            this.btnAdminData.Text = "Administración de Datos";
            this.btnAdminData.UseVisualStyleBackColor = true;
            this.btnAdminData.Click += new System.EventHandler(this.btnAdminData_Click);

            // btnSales (Ventas)
            this.btnSales.Location = new System.Drawing.Point(200, 50);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(120, 40);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Ventas";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);

            // btnLogout (Cerrar Sesión)
            this.btnLogout.Location = new System.Drawing.Point(125, 120);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnAdminData);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnLogout);
            this.Name = "MainForm";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAdminData; // Botón de Administración de Datos
        private System.Windows.Forms.Button btnSales;     // Botón de Ventas
        private System.Windows.Forms.Button btnLogout;   // Botón de Cerrar Sesión

    }
}

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
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnProducts
            this.btnProducts.Location = new System.Drawing.Point(50, 50);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(120, 40);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Productos";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);

            // btnClients
            this.btnClients.Location = new System.Drawing.Point(200, 50);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(120, 40);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Clientes";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);

            // btnEmployees
            this.btnEmployees.Location = new System.Drawing.Point(50, 120);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 40);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Empleados";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);

            // btnLogout
            this.btnLogout.Location = new System.Drawing.Point(200, 120);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnLogout);
            this.Name = "MainForm";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnLogout;
    }
}

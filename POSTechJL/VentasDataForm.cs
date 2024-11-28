using System;
using System.Windows.Forms;

namespace POSTechJL
{
    public partial class SalesDataForm : Form
    {
        public SalesDataForm()
        {
            InitializeComponent();
        }

        // Abrir formulario de ventas
        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm(); // Abre el formulario de ventas
            salesForm.Show();
            this.Hide();
        }

        // Volver al menú principal
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(); // Abre el formulario principal
            mainForm.Show();
            this.Hide();
        }

        #region InitializeComponent

        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnBack;

        private void InitializeComponent()
        {
            this.btnSales = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(50, 50);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(200, 50);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Gestión de Ventas";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(50, 120);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SalesDataForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSales);
            this.Name = "SalesDataForm";
            this.Text = "Menú de Ventas";
            this.ResumeLayout(false);
        }

        #endregion
    }
}

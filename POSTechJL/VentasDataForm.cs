using System;
using System.Windows.Forms;

namespace POSTechJL
{
    public partial class VentasDataForm : Form
    {
        public VentasDataForm()
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
    }
}
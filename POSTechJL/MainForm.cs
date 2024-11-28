using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POSTechJL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario principal.
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Regresa al login.
        }
    }
}

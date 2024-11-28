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

        // Método para abrir el formulario de administración de datos (productos, empleados, clientes)
        private void btnAdminData_Click(object sender, EventArgs e)
        {
            // Se abre el formulario para gestionar los datos de los productos, empleados y clientes
            AdminDataForm adminForm = new AdminDataForm();
            adminForm.ShowDialog();  // Muestra el formulario en modo modal
        }

        // Método para abrir el formulario de ventas
        private void btnSales_Click(object sender, EventArgs e)
        {
            // Se abre el formulario para realizar ventas
            SalesForm salesForm = new SalesForm();
            salesForm.Show();  // Muestra el formulario sin bloquear el formulario principal
        }

        // Método para cerrar sesión
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Lógica de logout, cerrar sesión y volver al formulario de login
            this.Close();  // Cierra el formulario principal.
            LoginForm loginForm = new LoginForm();  // Crea una instancia del formulario de login
            loginForm.Show();  // Muestra el formulario de login
        }
    }
}

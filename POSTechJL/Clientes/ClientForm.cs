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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            List<Client> clients = ClientLogic.GetAllClients();
            dgvClients.DataSource = clients;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Client client = new Client
            {
                NIT = txtNIT.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text
            };

            ClientLogic.AddClient(client);
            LoadClients();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientID.Text)) return;

            Client client = new Client
            {
                ClientID = int.Parse(txtClientID.Text),
                NIT = txtNIT.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text
            };

            ClientLogic.UpdateClient(client);
            LoadClients();
            ClearFields();
        }
        //eliminar
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientID.Text)) return;

            int clientId = int.Parse(txtClientID.Text);
            ClientLogic.DeleteClient(clientId);
            LoadClients();
            ClearFields();
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClients.Rows[e.RowIndex];
                txtClientID.Text = row.Cells["ClientID"].Value.ToString();
                txtNIT.Text = row.Cells["NIT"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtClientID.Clear();
            txtNIT.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }
    }
}

/*NOMAS CRENADO CODIGOS
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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            List<Client> clients = ClientLogic.GetAllClients();
            dgvClients.DataSource = clients;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Client client = new Client
            {
                NIT = txtNIT.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text
            };

            ClientLogic.AddClient(client);
            LoadClients();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientID.Text)) return;

            Client client = new Client
            {
                ClientID = int.Parse(txtClientID.Text),
                NIT = txtNIT.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text
            };

            ClientLogic.UpdateClient(client);
            LoadClients();
            ClearFields();
        }
        //eliminar
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientID.Text)) return;

            int clientId = int.Parse(txtClientID.Text);
            ClientLogic.DeleteClient(clientId);
            LoadClients();
            ClearFields();
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClients.Rows[e.RowIndex];
                txtClientID.Text = row.Cells["ClientID"].Value.ToString();
                txtNIT.Text = row.Cells["NIT"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtClientID.Clear();
            txtNIT.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }
    }
}*/
﻿using POSTechJL.Empleados;
using System;
using System.Windows.Forms;

namespace POSTechJL
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            dgvEmployees.DataSource = EmployeeLogic.GetAllEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                IdentificationNumber = txtIdentification.Text,
                Position = txtRole.Text,
                Username = txtUsername.Text,
                PasswordHash = txtPassword.Text
            };

            EmployeeLogic.AddEmployee(employee);
            LoadEmployees();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text)) return;

            var employee = new Employee
            {
                EmployeeID = int.Parse(txtEmployeeID.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                IdentificationNumber = txtIdentification.Text,
                Position = txtRole.Text,
                Username = txtUsername.Text,
                PasswordHash = txtPassword.Text
            };

            EmployeeLogic.UpdateEmployee(employee);
            LoadEmployees();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text)) return;

            int employeeId = int.Parse(txtEmployeeID.Text);
            EmployeeLogic.DeleteEmployee(employeeId);
            LoadEmployees();
            ClearFields();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvEmployees.Rows[e.RowIndex];
                txtEmployeeID.Text = row.Cells["EmployeeID"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtIdentification.Text = row.Cells["IdentificationNumber"].Value.ToString();
                txtRole.Text = row.Cells["Position"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["PasswordHash"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtIdentification.Clear();
            txtRole.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}

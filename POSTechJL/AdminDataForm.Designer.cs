using System;
using System.Windows.Forms;

namespace POSTechJL
{
    public partial class AdminDataForm : Form
    {

        private void InitializeComponent()
        {
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(50, 50);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(200, 50);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Gestionar Productos";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);

            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(50, 120);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(200, 50);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Gestionar Empleados";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);

            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(50, 190);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(200, 50);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Gestionar Clientes";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);

            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(50, 260);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // 
            // AdminDataForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnProducts);
            this.Name = "AdminDataForm";
            this.Text = "Administración de Datos";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnBack;

        
            
        }
    }

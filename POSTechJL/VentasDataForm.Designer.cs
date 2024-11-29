using System.Windows.Forms;
using System;

namespace POSTechJL
{
    public partial class VentasDataForm : Form
    {

        private void InitializeComponent()
        {
            this.btnSales = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(50, 50); // Posición en el formulario
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(200, 50); // Tamaño del botón
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Gestión de Ventas";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(50, 120); // Posición en el formulario
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50); // Tamaño del botón
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SalesDataForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 200); // Tamaño del formulario
            this.Controls.Add(this.btnBack); // Añadir el botón Volver
            this.Controls.Add(this.btnSales); // Añadir el botón Gestión de Ventas
            this.Name = "SalesDataForm";
            this.Text = "Menú de Ventas"; // Título del formulario
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnBack;
    }
}


        // Evento de "Gestión de Ventas"
        

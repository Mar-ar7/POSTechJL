namespace POSTechJL
{
    partial class ClientForm
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
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblNIT = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();

            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(130, 30);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(200, 22);
            this.txtClientID.TabIndex = 0;

            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(130, 60);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(200, 22);
            this.txtNIT.TabIndex = 1;

            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(130, 90);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 2;

            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(130, 120);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 3;

            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(130, 150);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 4;

            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(130, 180);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 5;

            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(360, 30);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.Size = new System.Drawing.Size(600, 300);
            this.dgvClients.TabIndex = 6;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // Labels
            // 
            this.lblClientID.Text = "ID:";
            this.lblClientID.Location = new System.Drawing.Point(30, 30);

            this.lblNIT.Text = "NIT:";
            this.lblNIT.Location = new System.Drawing.Point(30, 60);

            this.lblFirstName.Text = "Nombre:";
            this.lblFirstName.Location = new System.Drawing.Point(30, 90);

            this.lblLastName.Text = "Apellido:";
            this.lblLastName.Location = new System.Drawing.Point(30, 120);

            this.lblAddress.Text = "Dirección:";
            this.lblAddress.Location = new System.Drawing.Point(30, 150);

            this.lblPhone.Text = "Teléfono:";
            this.lblPhone.Location = new System.Drawing.Point(30, 180);

            // 
            // ClientForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 400);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblNIT);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Name = "ClientForm";
            this.Text = "Gestión de Clientes";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
    }
}

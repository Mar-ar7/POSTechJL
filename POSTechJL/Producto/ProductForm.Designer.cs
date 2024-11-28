namespace POSTechJL
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;

        // Declaración de los controles
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelectImage;  // Botón para seleccionar la imagen
        private System.Windows.Forms.PictureBox pictureBox;  // PictureBox para mostrar la imagen

        // Método para limpiar los recursos utilizados
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Método para inicializar los controles en el formulario
        private void InitializeComponent()
        {
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // txtProductID
            this.txtProductID.Location = new System.Drawing.Point(100, 20);  // Ubicación del ProductID (invisible)
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(200, 20);
            this.txtProductID.Visible = false;  // Hacemos el ProductID invisible

            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(100, 21);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 22);
            this.txtCode.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(100, 91);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 22);
            this.txtDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(100, 128);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(100, 165);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(200, 22);
            this.txtStock.TabIndex = 4;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(100, 202);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(200, 22);
            this.txtImagePath.TabIndex = 5;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(420, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(675, 450);
            this.dgvProducts.TabIndex = 6;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(159, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(271, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(136, 230);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(120, 23);
            this.btnSelectImage.TabIndex = 10;
            this.btnSelectImage.Text = "Seleccionar Imagen";
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(46, 312);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 150);
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // ProductForm
            // 
            this.ClientSize = new System.Drawing.Size(1146, 494);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pictureBox);
            this.Name = "ProductForm";
            this.Text = "Gestión de Productos";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
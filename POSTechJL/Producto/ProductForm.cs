using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace POSTechJL
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        // Método para manejar el botón de agregar producto
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Crear un objeto de tipo Product explícitamente
            Product product = new Product
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Description = txtDescription.Text,
                // Intentar convertir Price a decimal de forma segura
                Price = decimal.TryParse(txtPrice.Text, out decimal price) ? price : 0m, // Si no es válido, se asigna 0
                                                                                         // Intentar convertir Stock a int de forma segura
                Stock = int.TryParse(txtStock.Text, out int stock) ? stock : 0, // Si no es válido, se asigna 0
                ImagePath = txtImagePath.Text
            };

            if (string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Por favor, ingrese valores válidos en los campos de precio y stock.");
                return; // Detener la ejecución si los campos están vacíos
            }

            ProductLogic.AddProduct(product); // Llamada a la lógica de agregar
            LoadProducts();
            ClearFields();
        }

        // Método para manejar el botón de actualizar producto
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Crear un objeto de tipo Product explícitamente
            Product product = new Product
            {
                ProductID = int.Parse(txtProductID.Text),  // Asegúrate de pasar ProductID al actualizar
                Code = txtCode.Text,
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = decimal.Parse(txtPrice.Text),
                Stock = int.Parse(txtStock.Text),
                ImagePath = txtImagePath.Text
            };

            ProductLogic.UpdateProduct(product);  // Llamada a la lógica de actualización
            LoadProducts();
            ClearFields();
        }

        // Método para manejar el botón de eliminar producto
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Declaración explícita de productId como un entero
            int productId = int.Parse(txtProductID.Text);  // Asume que el ID del producto se selecciona en el formulario
            ProductLogic.DeleteProduct(productId);  // Llamada a la lógica de eliminación
            LoadProducts();
            ClearFields();
        }

        // Método para cargar productos en el DataGridView
        private void LoadProducts()
        {
            // Llamada explícita a la lógica para cargar productos, sin el uso de var
            dgvProducts.DataSource = ProductLogic.GetAllProducts(); // Llama a la lógica para cargar productos
        }

        // Método para limpiar los campos del formulario
        private void ClearFields()
        {
            txtCode.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtImagePath.Clear();
            txtProductID.Clear();  // Limpia el campo ProductID
            pictureBox.Image = null;  // Limpia la imagen mostrada
        }

        // Evento para cuando se selecciona un producto en el DataGridView
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Declaración explícita de la fila como un DataGridViewRow
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                // Asignar los valores a los campos de texto del formulario
                txtProductID.Text = row.Cells[0].Value.ToString();
                txtCode.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtDescription.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                txtStock.Text = row.Cells[5].Value.ToString();
                txtImagePath.Text = row.Cells[6].Value.ToString();

                // Muestra la imagen en el PictureBox
                string imagePath = row.Cells[6].Value.ToString();
                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
            }
        }

        // Método para seleccionar la imagen
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imágenes (*.jpg; *.jpeg; *.png; *.gif)|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos (*.*)|*.*",
                Title = "Selecciona una imagen"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                // Ruta relativa para la carpeta 'image' dentro del proyecto
                string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Images");

                // Verificar si la carpeta 'image' existe, si no, crearla
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Obtener solo el nombre del archivo de la imagen seleccionada
                string fileName = Path.GetFileName(selectedImagePath);
                string targetPath = Path.Combine(directoryPath, fileName);

                // Copiar la imagen seleccionada a la carpeta 'image' en el repositorio
                try
                {
                    File.Copy(selectedImagePath, targetPath, true); // true para sobrescribir si ya existe
                                                                    // Actualizar el TextBox con la ruta de la imagen
                    txtImagePath.Text = targetPath;

                    // Mostrar la imagen en el PictureBox
                    pictureBox.Image = Image.FromFile(targetPath);

                    MessageBox.Show("La imagen se ha guardado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hubo un error al guardar la imagen: {ex.Message}");
                }
            }
        }
        // Al cargar el formulario, cargamos los productos
        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

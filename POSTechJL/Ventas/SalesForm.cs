using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;  // Necesario para manejar imágenes
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POSTechJL
{
    public partial class SalesForm : Form
    {
        private string connectionString = "Server=localhost;Database=PointOfSale;Uid=root;Pwd=admin123;";
        private List<CartItem> cart = new List<CartItem>();

        public SalesForm()
        {
            InitializeComponent();
        }

        // Cargar productos desde la base de datos, incluyendo la imagen
        private void LoadProducts(string searchTerm)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ProductID, Code, Name, Price, ImagePath FROM Products WHERE Name LIKE @searchTerm OR Code LIKE @searchTerm";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }

        // Evento de búsqueda de productos
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            LoadProducts(searchTerm);
        }

        // Agregar producto al carrito y mostrar la imagen en el PictureBox
        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[0].Value);
                string productName = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                decimal unitPrice = Convert.ToDecimal(dgvProducts.Rows[e.RowIndex].Cells[3].Value);
                string imagePath = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();

                // Actualizar el PictureBox con la imagen del producto
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox.Image = null; // Si no existe la imagen, dejamos el PictureBox vacío
                }

                CartItem product = new CartItem
                {
                    ProductID = productId,
                    ProductName = productName,
                    UnitPrice = unitPrice,
                    Quantity = 1
                };

                // Verificar si el producto ya está en el carrito
                CartItem existingItem = cart.Find(item => item.ProductID == product.ProductID);
                if (existingItem != null)
                {
                    existingItem.Quantity += 1;
                }
                else
                {
                    cart.Add(product);
                }

                UpdateCart();
            }
        }

        // Actualizar el carrito y calcular el total
        private void UpdateCart()
        {
            lstCart.Items.Clear();
            decimal total = 0;
            foreach (CartItem item in cart)
            {
                lstCart.Items.Add($"{item.ProductName} - {item.Quantity} x ${item.UnitPrice}");
                total += item.Quantity * item.UnitPrice;
            }

            lblTotal.Text = "Total: $" + total.ToString("F2");
        }

        // Finalizar la venta
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agrega productos al carrito para realizar la venta.");
                return;
            }

            // Solicitar NIT o nombre del cliente
            string customerNIT = Interaction.InputBox("Ingrese el NIT o nombre del cliente (o 'CF' para consumidor final):", "Facturación", "", -1, -1);

            if (string.IsNullOrWhiteSpace(customerNIT))
            {
                MessageBox.Show("Debe ingresar un NIT o nombre de cliente.");
                return;
            }

            // Si el cliente es 'CF', asignamos un ID especial o lo que sea necesario
            int customerID = GetCustomerIDByNIT(customerNIT);  // Suponemos que tienes un método que obtiene el cliente por NIT o nombre

            // Registrar la venta
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insertar la venta (factura)
                    MySqlCommand saleCommand = new MySqlCommand("INSERT INTO Sales (CustomerID, EmployeeID, Total, SaleDate) VALUES (@CustomerID, @EmployeeID, @Total, @SaleDate)", connection);
                    saleCommand.Parameters.AddWithValue("@CustomerID", customerID); // Debe ser válido
                    saleCommand.Parameters.AddWithValue("@EmployeeID", 1);
                    saleCommand.Parameters.AddWithValue("@Total", cart.Sum(item => item.Quantity * item.UnitPrice));
                    saleCommand.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                    saleCommand.ExecuteNonQuery();

                    // Obtener el ID de la venta recién insertada
                    int saleID = (int)saleCommand.LastInsertedId;

                    // Insertar los detalles de la venta
                    foreach (CartItem item in cart)
                    {
                        // Insertar en SaleDetails
                        MySqlCommand saleDetailCommand = new MySqlCommand(
                            "INSERT INTO SaleDetails (SaleID, ProductID, Quantity, UnitPrice) VALUES (@SaleID, @ProductID, @Quantity, @UnitPrice)",
                            connection
                        );
                        saleDetailCommand.Parameters.AddWithValue("@SaleID", saleID);
                        saleDetailCommand.Parameters.AddWithValue("@ProductID", item.ProductID);
                        saleDetailCommand.Parameters.AddWithValue("@Quantity", item.Quantity);
                        saleDetailCommand.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                        saleDetailCommand.ExecuteNonQuery();

                        // Reducir inventario en Products
                        MySqlCommand updateInventoryCommand = new MySqlCommand(
                            "UPDATE Products SET Stock = Stock - @Quantity WHERE ProductID = @ProductID",
                            connection
                        );
                        updateInventoryCommand.Parameters.AddWithValue("@Quantity", item.Quantity);
                        updateInventoryCommand.Parameters.AddWithValue("@ProductID", item.ProductID);
                        updateInventoryCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Venta registrada exitosamente.");

                    // Limpiar carrito
                    cart.Clear();
                    UpdateCart();

                    // Mostrar resumen de la venta
                    ShowSaleSummary(saleID, customerNIT);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al procesar la venta: " + ex.Message);
                }
            }
        }

        // Método para obtener el CustomerID por NIT o nombre
        private int GetCustomerIDByNIT(string customerNIT)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Consulta para buscar el cliente por NIT o nombre completo
                MySqlCommand command = new MySqlCommand(
                    "SELECT CustomerID FROM Customers WHERE NIT = @NIT OR CONCAT(FirstName, ' ', LastName) = @FullName", connection);

                command.Parameters.AddWithValue("@NIT", customerNIT);
                command.Parameters.AddWithValue("@FullName", customerNIT);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result); // Devuelve el ID del cliente si existe
                }
                else
                {
                    // Si no se encuentra, insertar un nuevo cliente
                    MySqlCommand insertCommand = new MySqlCommand(
                        "INSERT INTO Customers (NIT, FirstName, LastName, Address, Phone) " +
                        "VALUES (@NIT, @FirstName, @LastName, 'N/A', 'N/A'); SELECT LAST_INSERT_ID();", connection
                    );
                    insertCommand.Parameters.AddWithValue("@NIT", customerNIT);
                    insertCommand.Parameters.AddWithValue("@FirstName", customerNIT);
                    insertCommand.Parameters.AddWithValue("@LastName", "N/A");

                    return Convert.ToInt32(insertCommand.ExecuteScalar()); // Devuelve el ID del nuevo cliente
                }
            }
        }

        // Método para mostrar el resumen de la venta
        private void ShowSaleSummary(int saleID, string customerNIT)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(
                    "SELECT p.Name, sd.Quantity, sd.UnitPrice FROM SaleDetails sd " +
                    "JOIN Products p ON sd.ProductID = p.ProductID WHERE sd.SaleID = @SaleID",
                    connection
                );
                command.Parameters.AddWithValue("@SaleID", saleID);
                MySqlDataReader reader = command.ExecuteReader();

                // Usamos un StringBuilder para construir la factura
                StringBuilder saleDetails = new StringBuilder();
                saleDetails.AppendLine("-------------------------------------------------------------------------");
                saleDetails.AppendLine("                                 FACTURA");
                saleDetails.AppendLine("-------------------------------------------------------------------------");
                saleDetails.AppendLine($"Factura N°: {saleID}");
                saleDetails.AppendLine($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
                saleDetails.AppendLine($"Cliente: {customerNIT}");
                saleDetails.AppendLine("-------------------------------------------------------------------------");
                saleDetails.AppendLine("DETALLES:");
                saleDetails.AppendLine("-------------------------------------------------------------------------");

                decimal total = 0;

                while (reader.Read())
                {
                    string productName = reader.GetString(0);
                    int quantity = reader.GetInt32(1);
                    decimal unitPrice = reader.GetDecimal(2);
                    decimal itemTotal = quantity * unitPrice;

                    // Detalles verticales
                    saleDetails.AppendLine($"Producto: {productName}");
                    saleDetails.AppendLine($"Cantidad: {quantity}");
                    saleDetails.AppendLine($"Precio Unitario: ${unitPrice:F2}");
                    saleDetails.AppendLine($"Total: ${itemTotal:F2}");
                    saleDetails.AppendLine("-------------------------------------------------------------------------");
                    total += itemTotal;
                }

                saleDetails.AppendLine($"Subtotal: ${total:F2}");
                saleDetails.AppendLine($"Total: ${total:F2}");
                saleDetails.AppendLine("-------------------------------------------------------------------------");
                saleDetails.AppendLine("                     ¡Gracias por su compra!");
                saleDetails.AppendLine("-------------------------------------------------------------------------");

                // Crear una instancia del formulario InvoiceForm
                InvoiceForm invoiceForm = new InvoiceForm();
                invoiceForm.SetInvoiceDetails(saleDetails.ToString());
                invoiceForm.ShowDialog(); // Mostrar el formulario con la factura
            }
        }


        // Clase para representar los productos en el carrito
        public class CartItem
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
        }
    }
}

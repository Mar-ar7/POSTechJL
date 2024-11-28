using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using POSTechJL;

public class ProductLogic
{
    private static string connectionString = "Server=localhost;Database=PointOfSale;Uid=root;Pwd=admin123;";

    // Método para obtener todos los productos
    public static List<Product> GetAllProducts()
    {
        List<Product> products = new List<Product>();
        string query = "SELECT * FROM Products";

        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            using (var cmd = new MySqlCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product
                        {
                            ProductID = reader.GetInt32("ProductID"),
                            Code = reader.GetString("Code"),
                            Name = reader.GetString("Name"),
                            Description = reader.GetString("Description"),
                            Price = reader.GetDecimal("Price"),
                            Stock = reader.GetInt32("Stock"),
                            ImagePath = reader.GetString("ImagePath")
                        };
                        products.Add(product);
                    }
                }
            }
        }
        return products;
    }

    // Método para agregar un producto
    public static void AddProduct(Product product)
    {
        string query = "INSERT INTO Products (Code, Name, Description, Price, Stock, ImagePath) VALUES (@Code, @Name, @Description, @Price, @Stock, @ImagePath)";

        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Code", product.Code);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@ImagePath", product.ImagePath);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Método para actualizar un producto
    public static void UpdateProduct(Product product)
    {
        string query = "UPDATE Products SET Code = @Code, Name = @Name, Description = @Description, Price = @Price, Stock = @Stock, ImagePath = @ImagePath WHERE ProductID = @ProductID";

        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                cmd.Parameters.AddWithValue("@Code", product.Code);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@ImagePath", product.ImagePath);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Método para eliminar un producto
    public static void DeleteProduct(int productId)
    {
        string query = "DELETE FROM Products WHERE ProductID = @ProductID";

        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}


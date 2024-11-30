using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace POSTechJL
{
    public class ClientLogic
    {
        private static string connectionString = "Server=localhost;Database=PointOfSale;Uid=root;Pwd=admin123;";

        // Obtener todos los clientes
        public static List<Client> GetAllClients()
        {
            List<Client> clients = new List<Client>();
            string query = "SELECT * FROM Customers";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client client = new Client
                            {
                                ClientID = reader.GetInt32("CustomerID"),
                                NIT = reader.GetString("NIT"),
                                FirstName = reader.GetString("FirstName"),
                                LastName = reader.GetString("LastName"),
                                Address = reader.GetString("Address"),
                                Phone = reader.GetString("Phone")
                            };
                            clients.Add(client);
                        }
                    }
                }
            }
            return clients;
        }

        // Agregar a un nuevo cliente
        public static void AddClient(Client client)
        {
            string query = "INSERT INTO Customers (NIT, FirstName, LastName, Address, Phone) VALUES (@NIT, @FirstName, @LastName, @Address, @Phone)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NIT", client.NIT);
                    cmd.Parameters.AddWithValue("@FirstName", client.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", client.LastName);
                    cmd.Parameters.AddWithValue("@Address", client.Address);
                    cmd.Parameters.AddWithValue("@Phone", client.Phone);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Actualizar la informacion de un cliente
        public static void UpdateClient(Client client)
        {
            string query = "UPDATE Customers SET NIT = @NIT, FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone WHERE CustomerID = @CustomerID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", client.ClientID);
                    cmd.Parameters.AddWithValue("@NIT", client.NIT);
                    cmd.Parameters.AddWithValue("@FirstName", client.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", client.LastName);
                    cmd.Parameters.AddWithValue("@Address", client.Address);
                    cmd.Parameters.AddWithValue("@Phone", client.Phone);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar a un cliente
        public static void DeleteClient(int clientId)
        {
            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", clientId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


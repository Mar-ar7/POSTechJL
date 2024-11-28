using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace POSTechJL
{
    public static class LoginLogic
    {
        private static string connectionString = "Server=localhost;Database=PointOfSale;Uid=root;Pwd=admin123;";

        public static bool AuthenticateUser(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Employees WHERE Username = @Username AND PasswordHash = @PasswordHash";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Retorna true si existe al menos un usuario con las credenciales.
                }
            }
        }
    }
}

using MySql.Data.MySqlClient;
using POSTechJL.Empleados;
using System;
using System.Collections.Generic;

namespace POSTechJL
{
    public class EmployeeLogic
    {
        private static string connectionString = "Server=localhost;Database=PointOfSale;Uid=root;Pwd=admin123;";

        // Obtener todos los empleados
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string query = "SELECT * FROM Employees";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employee = new Employee
                            {
                                EmployeeID = reader.GetInt32("EmployeeID"),
                                FirstName = reader.GetString("FirstName"),
                                LastName = reader.GetString("LastName"),
                                IdentificationNumber = reader.GetString("IdentificationNumber"),
                                Position = reader.GetString("Position"),
                                Username = reader.GetString("Username"),
                                PasswordHash = reader.GetString("PasswordHash")
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees;
        }

        // Agregar empleado
        public static void AddEmployee(Employee employee)
        {
            string query = "INSERT INTO Employees (FirstName, LastName, IdentificationNumber, Position, Username, PasswordHash) " +
                           "VALUES (@FirstName, @LastName, @IdentificationNumber, @Position, @Username, @PasswordHash)";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@IdentificationNumber", employee.IdentificationNumber);
                    cmd.Parameters.AddWithValue("@Position", employee.Position);
                    cmd.Parameters.AddWithValue("@Username", employee.Username);
                    cmd.Parameters.AddWithValue("@PasswordHash", employee.PasswordHash);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Actualizar empleado
        public static void UpdateEmployee(Employee employee)
        {
            string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, IdentificationNumber = @IdentificationNumber, " +
                           "Position = @Position, Username = @Username, PasswordHash = @PasswordHash WHERE EmployeeID = @EmployeeID";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                    cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@IdentificationNumber", employee.IdentificationNumber);
                    cmd.Parameters.AddWithValue("@Position", employee.Position);
                    cmd.Parameters.AddWithValue("@Username", employee.Username);
                    cmd.Parameters.AddWithValue("@PasswordHash", employee.PasswordHash);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar empleado
        public static void DeleteEmployee(int employeeId)
        {
            string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


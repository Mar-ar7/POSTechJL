using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTechJL.Empleados
{
    public class Employee
    {
        public int EmployeeID { get; set; } // ID único
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; } // DPI u otro número de identificación
        public string Position { get; set; } // Cargo
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}
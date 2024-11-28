using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTechJL
{
    public class Product
    {
        public int ProductID { get; set; }        // Este es el campo autoincremental
        public string Code { get; set; }          // Código del producto
        public string Name { get; set; }          // Nombre del producto
        public string Description { get; set; }   // Descripción del producto
        public decimal Price { get; set; }        // Precio del producto
        public int Stock { get; set; }            // Stock del producto
        public string ImagePath { get; set; }     // Ruta de la imagen
    }

}

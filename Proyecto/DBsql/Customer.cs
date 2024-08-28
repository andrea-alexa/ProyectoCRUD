using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBsql // Define el espacio de nombres para la clase de cliente en la base de datos.
{
    public class Customer // Define la clase "Customer" para representar a un cliente en el sistema.
    {
        // Propiedad para almacenar el ID del cliente.
        public string CustomerID { get; set; }

        // Propiedad para almacenar el nombre de la empresa del cliente.
        public string CompanyName { get; set; }

        // Propiedad para almacenar el nombre de contacto del cliente.
        public string ContactName { get; set; }

        // Propiedad para almacenar el título de contacto del cliente.
        public string ContactTitle { get; set; }

        // Propiedad para almacenar la dirección del cliente.
        public string Address { get; set; }

        // Propiedad para almacenar la ciudad del cliente.
        public string City { get; set; }

        // Propiedad para almacenar la región del cliente.
        public string Region { get; set; }

        // Propiedad para almacenar el código postal del cliente.
        public string PostalCode { get; set; }

        // Propiedad para almacenar el país del cliente.
        public string Country { get; set; }

        // Propiedad para almacenar el teléfono del cliente.
        public string Phone { get; set; }

        // Propiedad para almacenar el fax del cliente.
        public string Fax { get; set; }
    }
}

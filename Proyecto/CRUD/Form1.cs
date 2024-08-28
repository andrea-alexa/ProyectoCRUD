using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBsql;
using System.Data.SqlClient;
using System.Reflection;

namespace CRUD // Define el espacio de nombres para la aplicación CRUD.
{
    public partial class Form1 : Form // Define una clase parcial "Form1" que hereda de "Form", representando la interfaz gráfica.
    {
        RepositoryCustomer repositoryCustomer = new RepositoryCustomer(); // Crea una instancia de "RepositoryCustomer" para manejar las operaciones de datos.

        public Form1() // Constructor de la clase "Form1".
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        private void btnCargarInfo_Click(object sender, EventArgs e) // Evento del botón para cargar información.
        {
            var Customer = repositoryCustomer.CargarTodos(); // Llama al método para cargar todos los clientes.
            dataGrid.DataSource = Customer; // Asigna los datos obtenidos al "DataGrid".
        }

        private void btnBuscar_Click(object sender, EventArgs e) // Evento del botón para buscar un cliente por ID.
        {
            var cliente = repositoryCustomer.BuscarPorID(txtBuscar.Text); // Busca un cliente usando el ID ingresado.

            // Muestra los detalles del cliente encontrado en los campos de texto correspondientes.
            txtCustomerID.Text = cliente.CustomerID;
            txtCompanyName.Text = cliente.CompanyName;
            txtContactName.Text = cliente.ContactName;
            txtContactTitle.Text = cliente.ContactTitle;
            txtAddress.Text = cliente.Address;
            txtCity.Text = cliente.City;
            txtRegion.Text = cliente.Region;
            txtPostalCode.Text = cliente.PostalCode;
            txtCountry.Text = cliente.Country;
            txtPhone.Text = cliente.Phone;
            txtFax.Text = cliente.Fax;
        }

        private void btnAgregar_Click(object sender, EventArgs e) // Evento del botón para agregar un nuevo cliente.
        {
            var resultado = 0; // Inicializa una variable para almacenar el resultado de la operación.

            var nuevoCliente = ObtenerCliente(); // Obtiene los datos del nuevo cliente a partir de los campos de texto.

            if (validarCampoNull(nuevoCliente) == false) // Verifica si todos los campos están completos.
            {
                resultado = repositoryCustomer.AgregarCliente(nuevoCliente); // Llama al método para agregar el cliente.
                MessageBox.Show("Guardado. " + "Filas modificadas = " + resultado); // Muestra un mensaje con el número de filas modificadas.
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos"); // Muestra un mensaje si hay campos vacíos.
            }
        }

        public Boolean validarCampoNull(Object objeto) // Método para validar si algún campo del objeto es nulo o vacío.
        {
            foreach (PropertyInfo property in objeto.GetType().GetProperties()) // Recorre todas las propiedades del objeto.
            {
                object value = property.GetValue(objeto, null); // Obtiene el valor de la propiedad.
                if ((string)value == "") // Verifica si el valor es una cadena vacía.
                {
                    return true; // Retorna true si hay una cadena vacía.
                }
            }
            return false; // Retorna false si todos los campos tienen valor.
        }

        private void btnModificar_Click(object sender, EventArgs e) // Evento del botón para modificar un cliente existente.
        {
            var actualizarCliente = ObtenerCliente(); // Obtiene los datos actualizados del cliente.
            int actualizado = repositoryCustomer.ActualizarCliente(actualizarCliente); // Llama al método para actualizar el cliente.
            MessageBox.Show($"Filas actualizadas = {actualizado}"); // Muestra un mensaje con el número de filas actualizadas.
        }

        private Customer ObtenerCliente() // Método para obtener un nuevo cliente a partir de los campos de texto.
        {
            var nuevoCliente = new Customer
            {
                CustomerID = txtCustomerID.Text,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text
            };

            return nuevoCliente; // Retorna el objeto cliente creado.
        }

        private void btnEliminar_Click(object sender, EventArgs e) // Evento del botón para eliminar un cliente.
        {
            int elimindo = repositoryCustomer.EliminarCliente(txtCustomerID.Text); // Llama al método para eliminar el cliente por ID.
            MessageBox.Show("Filas eliminadas = " + elimindo); // Muestra un mensaje con el número de filas eliminadas.
        }
    }
}

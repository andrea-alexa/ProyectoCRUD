using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBsql
{
    public class RepositoryCustomer
    {
        // Método para cargar todos los clientes desde la base de datos.
        public List<Customer> CargarTodos()
        {
            using (var conexion = ConexionDB.GetSql()) // Obtiene una conexión SQL usando la clase ConexionDB.
            {
                // Construye la consulta SQL para seleccionar todos los campos de la tabla Customers.
                String Cargar = "";
                Cargar = Cargar + "SELECT [CustomerID] " + "\n";
                Cargar = Cargar + "      ,[CompanyName] " + "\n";
                Cargar = Cargar + "      ,[ContactName] " + "\n";
                Cargar = Cargar + "      ,[ContactTitle] " + "\n";
                Cargar = Cargar + "      ,[Address] " + "\n";
                Cargar = Cargar + "      ,[City] " + "\n";
                Cargar = Cargar + "      ,[Region] " + "\n";
                Cargar = Cargar + "      ,[PostalCode] " + "\n";
                Cargar = Cargar + "      ,[Country] " + "\n";
                Cargar = Cargar + "      ,[Phone] " + "\n";
                Cargar = Cargar + "      ,[Fax] " + "\n";
                Cargar = Cargar + "  FROM [dbo].[Customers]";

                using (SqlCommand comando = new SqlCommand(Cargar, conexion)) // Ejecuta la consulta usando SqlCommand.
                {
                    SqlDataReader reader = comando.ExecuteReader(); // Lee los resultados de la consulta.
                    List<Customer> Customers = new List<Customer>(); // Lista para almacenar los clientes.

                    // Lee cada fila del resultado y la agrega a la lista de clientes.
                    while (reader.Read())
                    {
                        var customers = LeerDatos(reader);
                        Customers.Add(customers);
                    }
                    return Customers; // Retorna la lista de clientes.
                }
            }
        }

        // Método para buscar un cliente por su ID.
        public Customer BuscarPorID(string id)
        {
            using (var conexion = ConexionDB.GetSql()) // Obtiene una conexión SQL usando la clase ConexionDB.
            {
                // Construye la consulta SQL para seleccionar un cliente específico por su ID.
                String Buscar = "";
                Buscar = Buscar + "SELECT [CustomerID] " + "\n";
                Buscar = Buscar + "      ,[CompanyName] " + "\n";
                Buscar = Buscar + "      ,[ContactName] " + "\n";
                Buscar = Buscar + "      ,[ContactTitle] " + "\n";
                Buscar = Buscar + "      ,[Address] " + "\n";
                Buscar = Buscar + "      ,[City] " + "\n";
                Buscar = Buscar + "      ,[Region] " + "\n";
                Buscar = Buscar + "      ,[PostalCode] " + "\n";
                Buscar = Buscar + "      ,[Country] " + "\n";
                Buscar = Buscar + "      ,[Phone] " + "\n";
                Buscar = Buscar + "      ,[Fax] " + "\n";
                Buscar = Buscar + "  FROM [dbo].[Customers] " + "\n";
                Buscar = Buscar + $"  Where CustomerID = @customerId"; // Filtra por CustomerID.

                using (SqlCommand comando = new SqlCommand(Buscar, conexion)) // Ejecuta la consulta usando SqlCommand.
                {
                    comando.Parameters.AddWithValue("customerId", id); // Agrega el parámetro de ID.

                    var reader = comando.ExecuteReader(); // Lee los resultados de la consulta.
                    Customer customers = null; // Inicializa la variable de cliente.

                    // Si se encuentra un resultado, lee los datos del cliente.
                    if (reader.Read())
                    {
                        customers = LeerDatos(reader);
                    }
                    return customers; // Retorna el cliente encontrado o null si no se encuentra.
                }
            }
        }

        // Método para leer los datos del SqlDataReader y convertirlos en un objeto Customer.
        public Customer LeerDatos(SqlDataReader reader)
        {
            Customer customers = new Customer();
            customers.CustomerID = reader["CustomerID"] == DBNull.Value ? " " : (String)reader["CustomerID"];
            customers.CompanyName = reader["CompanyName"] == DBNull.Value ? "" : (String)reader["CompanyName"];
            customers.ContactName = reader["ContactName"] == DBNull.Value ? "" : (String)reader["ContactName"];
            customers.ContactTitle = reader["ContactTitle"] == DBNull.Value ? "" : (String)reader["ContactTitle"];
            customers.Address = reader["Address"] == DBNull.Value ? "" : (String)reader["Address"];
            customers.City = reader["City"] == DBNull.Value ? "" : (String)reader["City"];
            customers.Region = reader["Region"] == DBNull.Value ? "" : (String)reader["Region"];
            customers.PostalCode = reader["PostalCode"] == DBNull.Value ? "" : (String)reader["PostalCode"];
            customers.Country = reader["Country"] == DBNull.Value ? "" : (String)reader["Country"];
            customers.Phone = reader["Phone"] == DBNull.Value ? "" : (String)reader["Phone"];
            customers.Fax = reader["Fax"] == DBNull.Value ? "" : (String)reader["Fax"];

            return customers; // Retorna el objeto Customer con los datos leídos.
        }

        // Método para agregar un nuevo cliente a la base de datos.
        public int AgregarCliente(Customer customer)
        {
            using (var conexion = ConexionDB.GetSql()) // Obtiene una conexión SQL usando la clase ConexionDB.
            {
                // Construye la consulta SQL para insertar un nuevo cliente.
                String Agregar = "";
                Agregar = Agregar + "INSERT INTO [dbo].[Customers] " + "\n";
                Agregar = Agregar + "           ([CustomerID] " + "\n";
                Agregar = Agregar + "           ,[CompanyName] " + "\n";
                Agregar = Agregar + "           ,[ContactName] " + "\n";
                Agregar = Agregar + "           ,[ContactTitle] " + "\n";
                Agregar = Agregar + "           ,[Address] " + "\n";
                Agregar = Agregar + "           ,[City] " + "\n";
                Agregar = Agregar + "           ,[Region] " + "\n";
                Agregar = Agregar + "           ,[PostalCode] " + "\n";
                Agregar = Agregar + "           ,[Country] " + "\n";
                Agregar = Agregar + "           ,[Phone] " + "\n";
                Agregar = Agregar + "           ,[Fax]) " + "\n";
                Agregar = Agregar + "     VALUES " + "\n";
                Agregar = Agregar + "           (@CustomerID " + "\n";
                Agregar = Agregar + "           ,@CompanyName " + "\n";
                Agregar = Agregar + "           ,@ContactName " + "\n";
                Agregar = Agregar + "           ,@ContactTitle " + "\n";
                Agregar = Agregar + "           ,@Address " + "\n";
                Agregar = Agregar + "           ,@City" + "\n";
                Agregar = Agregar + "           ,@Region" + "\n";
                Agregar = Agregar + "           ,@PostalCode" + "\n";
                Agregar = Agregar + "           ,@Country" + "\n";
                Agregar = Agregar + "           ,@Phone" + "\n";
                Agregar = Agregar + "           ,@Fax)";

                using (var comando = new SqlCommand(Agregar, conexion)) // Ejecuta la consulta usando SqlCommand.
                {
                    int agregado = Parametros(customer, comando); // Establece los parámetros y ejecuta la consulta.
                    return agregado; // Retorna el número de filas afectadas.
                }
            }
        }

        // Método para actualizar un cliente existente en la base de datos.
        public int ActualizarCliente(Customer customer)
        {
            using (var conexion = ConexionDB.GetSql()) // Obtiene una conexión SQL usando la clase ConexionDB.
            {
                // Construye la consulta SQL para actualizar un cliente existente.
                String ActualizarPorID = "";
                ActualizarPorID = ActualizarPorID + "UPDATE [dbo].[Customers] " + "\n";
                ActualizarPorID = ActualizarPorID + "   SET [CustomerID] = @CustomerID " + "\n";
                ActualizarPorID = ActualizarPorID + "      ,[CompanyName] = @CompanyName " + "\n";
                ActualizarPorID = ActualizarPorID + "      ,[ContactName] = @ContactName " + "\n";
                ActualizarPorID = ActualizarPorID + "      ,[ContactTitle] = @ContactTitle " + "\n";
                ActualizarPorID = ActualizarPorID + "      ,[Address] = @Address " + "\n";
                ActualizarPorID = ActualizarPorID + "      ,[City] = @City " + "\n";
                ActualizarPorID = ActualizarPorID + "      ,[Region] = @Region " + "\n";
                ActualizarPorID = ActualizarPorID + "      ,[PostalCode] = @PostalCode " + "\n";
                ActualizarPorID = ActualizarPorID + "      ,[Country] = @Country " + "\n";
                ActualizarPorID = ActualizarPorID + "      ,[Phone] = @Phone " + "\n";
                ActualizarPorID = ActualizarPorID + "      ,[Fax] = @Fax " + "\n";
                ActualizarPorID = ActualizarPorID + " WHERE CustomerID= @CustomerID"; // Filtra por CustomerID.

                using (var comando = new SqlCommand(ActualizarPorID, conexion)) // Ejecuta la consulta usando SqlCommand.
                {
                    int actualizado = Parametros(customer, comando); // Establece los parámetros y ejecuta la consulta.
                    return actualizado; // Retorna el número de filas afectadas.
                }
            }
        }

        // Método para establecer los parámetros en el comando SQL.
        public int Parametros(Customer customer, SqlCommand comando)
        {
            // Establece los parámetros del comando con los valores del objeto Customer.
            comando.Parameters.AddWithValue("CustomerID", customer.CustomerID);
            comando.Parameters.AddWithValue("CompanyName", customer.CompanyName);
            comando.Parameters.AddWithValue("ContactName", customer.ContactName);
            comando.Parameters.AddWithValue("ContactTitle", customer.ContactTitle);
            comando.Parameters.AddWithValue("Address", customer.Address);
            comando.Parameters.AddWithValue("City", customer.City);
            comando.Parameters.AddWithValue("Region", customer.Region);
            comando.Parameters.AddWithValue("PostalCode", customer.PostalCode);
            comando.Parameters.AddWithValue("Country", customer.Country);
            comando.Parameters.AddWithValue("Phone", customer.Phone);
            comando.Parameters.AddWithValue("Fax", customer.Fax);

            // Ejecuta el comando SQL y retorna el número de filas afectadas.
            var agregado = comando.ExecuteNonQuery();
            return agregado;
        }

        // Método para eliminar un cliente de la base de datos por su ID.
        public int EliminarCliente(string id)
        {
            using (var conexion = ConexionDB.GetSql()) // Obtiene una conexión SQL usando la clase ConexionDB.
            {
                // Construye la consulta SQL para eliminar un cliente por su ID.
                String Eliminar = "";
                Eliminar = Eliminar + "DELETE FROM [dbo].[Customers] " + "\n";
                Eliminar = Eliminar + "      WHERE CustomerID = @CustomerID";

                using (SqlCommand comando = new SqlCommand(Eliminar, conexion)) // Ejecuta la consulta usando SqlCommand.
                {
                    comando.Parameters.AddWithValue("@CustomerID", id); // Agrega el parámetro de ID.
                    int elimindo = comando.ExecuteNonQuery(); // Ejecuta el comando y obtiene el número de filas eliminadas.
                    return elimindo; // Retorna el número de filas eliminadas.
                }
            }
        }
    }
}

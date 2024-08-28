using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace DBsql // Define el espacio de nombres para la conexión con la base de datos.
{
    public class ConexionDB // Define la clase estática "ConexionDB" para manejar la conexión a la base de datos.
    {
        public static string ConnectionString // Propiedad estática para obtener la cadena de conexión a la base de datos.
        {
            get
            {
                // Obtiene la cadena de conexión desde la configuración de la aplicación.
                string CadenaConexion = ConfigurationManager.ConnectionStrings["NWConnection"].ConnectionString;

                // Crea un objeto SqlConnectionStringBuilder para manipular la cadena de conexión.
                SqlConnectionStringBuilder conexionBuilder = new SqlConnectionStringBuilder(CadenaConexion);

                // Asigna el nombre de la aplicación si se ha especificado, de lo contrario, mantiene el valor por defecto.
                conexionBuilder.ApplicationName = ApplicationName ?? conexionBuilder.ApplicationName;

                // Asigna el tiempo de espera de conexión si se ha especificado, de lo contrario, mantiene el valor por defecto.
                conexionBuilder.ConnectTimeout = (ConnectionTimeout > 0) ? ConnectionTimeout : conexionBuilder.ConnectTimeout;

                // Retorna la cadena de conexión completa.
                return conexionBuilder.ToString();
            }
        }

        // Propiedad estática para configurar el tiempo de espera de conexión.
        public static int ConnectionTimeout { get; set; }

        // Propiedad estática para configurar el nombre de la aplicación en la cadena de conexión.
        public static string ApplicationName { get; set; }

        // Método estático para obtener una conexión SQL abierta.
        public static SqlConnection GetSql()
        {
            // Crea una nueva instancia de SqlConnection usando la cadena de conexión obtenida.
            SqlConnection conexion = new SqlConnection(ConnectionString);

            // Abre la conexión a la base de datos.
            conexion.Open();

            // Retorna la conexión abierta.
            return conexion;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PEASA_App.Clases
{
    public class MySQLConnectionManager : IDisposable
    {
        private MySqlConnection connection;
        private string connectionString;

        public MySQLConnectionManager(string server, string database, string username, string password)
        {
            // Configurar la cadena de conexión de manera segura
            MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder
            {
                Server = server,
                Database = database,
                UserID = username,
                Password = password
            };

            connectionString = connectionStringBuilder.ConnectionString;

            // Inicializar la conexión
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
            //           MessageBox.Show("Conexión establecida correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return connection;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Error al abrir la conexión: {ex.Message}");
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Debug.WriteLine("Conexión cerrada correctamente.");
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine($"Error al cerrar la conexión: {ex.Message}");
                throw new Exception($"Error al cerrar la conexión: {ex.Message}");
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void Dispose()
        {
            // Asegúrate de cerrar la conexión al liberar los recursos
            CloseConnection();
            GC.SuppressFinalize(this);
        }

        public void ExecuteNonQuery(string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                try
                {
                    OpenConnection();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

    }
}

    
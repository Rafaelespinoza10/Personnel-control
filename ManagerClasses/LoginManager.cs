using MySql.Data.MySqlClient;
using PEASA_App.Clases;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PEASA_App
{
    public class LoginManager
    {
        private readonly  MySQLConnectionManager _connectionManager;
        private const string  nameTableLogin = "gerents";
        private const string nameIDTable = "name";
        private const string passNameTable = "password";
        private const string emailNameTable = "email";

        public LoginManager(string server, string database, string username, string password)
        {
            _connectionManager = new MySQLConnectionManager(server, database, username, password);
        }

        public bool AuthenticateUser(string username, string password)
        {
            MySqlConnection connection = null;

            try
            {
                connection = _connectionManager.OpenConnection();
                return connection != null && getUser(username, password, connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al autenticar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // No cerramos la conexión aquí para que pueda ser utilizada en el futuro.
                // La conexión se cerrará cuando se libere el recurso MySqlConnection.
            }
        }


        public bool getUser(string username,  string password, MySqlConnection connection)
        {
            try
            {
                string query = $"SELECT COUNT(*) FROM {nameTableLogin} WHERE {nameIDTable} = @{nameIDTable} AND {passNameTable} = @{passNameTable} ";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue($"@{nameIDTable}", username);
                    cmd.Parameters.AddWithValue($"@{passNameTable}", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejercutar la consulta : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RegisterUser(string username, string password, string email)
        {
            try
            {
                using (MySqlConnection connection = _connectionManager.OpenConnection())
                {
                    return connection != null && registerUser(username, password, email, connection);
                }
            }
            catch (Exception ex)
            {
                //LogError($"Error al registrar usuario: {ex.Message}");
                return false;
            }
        }

        private bool registerUser(string username, string password, string email, MySqlConnection connection)
        {
            try
            {
                string query = $"INSERT INTO {nameTableLogin} ({nameIDTable}, {passNameTable}, {emailNameTable}) VALUES (@{nameIDTable}, @{passNameTable}, @{emailNameTable})";
            
                using(MySqlCommand cmd = new MySqlCommand( query, connection))
                {
                    cmd.Parameters.AddWithValue($"@{nameIDTable}", username);
                    cmd.Parameters.AddWithValue($"@{passNameTable}", password);
                    cmd.Parameters.AddWithValue($"@{emailNameTable}", email);

                    cmd.ExecuteNonQuery();
                    return true;
                }


            }catch(Exception ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void CloseConnection()
        {
            _connectionManager.CloseConnection();
        }

    }
}

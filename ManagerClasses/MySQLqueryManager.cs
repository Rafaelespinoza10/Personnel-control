using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;

namespace PEASA_App.Clases
{
    internal class MySQLQueryManager
    {
        private MySqlConnection connection;

        public MySQLQueryManager(MySqlConnection connection)
        {
            this.connection = connection;

        }

        public DataTable ExecuteSelectQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        // Agregar parámetros a la consulta
                        foreach (var parameter in parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                throw new Exception($"Error al ejecutar la consulta: {ex.Message}");
            }
            return dataTable;
        }


        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Agregar parámetros a la consulta
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    // Ejecutar la consulta y devolver el número de filas afectadas
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                throw new Exception($"Error al ejecutar la consulta: {ex.Message}");
            }

        }


        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        // Agregar parámetros a la consulta
                        foreach (var parameter in parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    // Ejecutar la consulta y devolver el resultado escalar
                    return cmd.ExecuteScalar();
                }
            }
            catch (MySqlException ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                throw new Exception($"Error al ejecutar la consulta: {ex.Message}");
            }
        }

    }
}

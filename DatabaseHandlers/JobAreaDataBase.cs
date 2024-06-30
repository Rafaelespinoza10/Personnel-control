using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public class JobAreaDataBase
    {
        private MySQLQueryManager queryManager;
        private const string table_name = "areas";
        private const string col1 = "name";


        internal JobAreaDataBase(MySQLQueryManager queryManager)
        {
            this.queryManager = queryManager;
        }

        public DataTable GetAreaJobTable()
        {

            string query = $"SELECT * FROM {table_name}";
            return queryManager.ExecuteSelectQuery(query);

        }

        public void AddArea(string nameArea)
        {
            string query = $"INSERT INTO {table_name} ({col1}) VALUES (@name)";
            try
            {
                // Ejecutar la consulta utilizando parámetros
                int rowsAffected = queryManager.ExecuteNonQuery(query, new Dictionary<string, object>
        {
                    { "name", nameArea }

        });

                // Verificar si la inserción fue exitosa
                if (rowsAffected > 0)
                {
                    MessageBox.Show("El área de trabajo se ha agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el área de trabajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                MessageBox.Show($"Error al agregar el área de trabajo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteJobCenter(string name)
        {
            string query = $"DELETE FROM {table_name} WHERE {col1} = @name";
            try
            {
                int rowsAffected = queryManager.ExecuteNonQuery(query, new Dictionary<string, object>
        {
            { "@name", name}
        });

                if (rowsAffected > 0)
                {
                    MessageBox.Show("El área de trabajo se ha eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el area de trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el área  de trabajo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable SearchAreaJob(string name)
        {
            string query = $"SELECT * FROM {table_name} WHERE {col1} LIKE @name";
            try
            {

                // Ejecutar la consulta utilizando parámetros
                return queryManager.ExecuteSelectQuery(query, new Dictionary<string, object>
        {
            { "@name", $"%{name}%" } // Utilizamos % para que coincida con cualquier parte del nombre de la línea
        });
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                MessageBox.Show($"Error al buscar el centro de trabajo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}

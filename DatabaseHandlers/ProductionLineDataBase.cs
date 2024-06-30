using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public class ProductionLineDataBase
    {
        private MySQLQueryManager queryManager;
        private const string table_name = "Line";
        private const string Column1 = "name";

       internal ProductionLineDataBase(MySQLQueryManager queryManager)
        {
            this.queryManager = queryManager;
        }

        public DataTable GetDataProductionLine()
        {
            string query = $"SELECT * FROM {table_name}";
            return queryManager.ExecuteSelectQuery(query);
        }

        public void AddLineProduction(string nameLine)
        {
            string query = $"INSERT INTO {table_name} ({Column1}) VALUES (@nameLine)";
            try
            {
                // Ejecutar la consulta utilizando parámetros
                int rowsAffected = queryManager.ExecuteNonQuery(query, new Dictionary<string, object>
        {
            { "@nameLine", nameLine }
        });

                // Verificar si la inserción fue exitosa
                if (rowsAffected > 0)
                {
                    MessageBox.Show("La línea de producción se ha agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la línea de producción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                MessageBox.Show($"Error al agregar la línea de producción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       public  DataTable SearchLineProduction(string nameline)
        {
            string query = $"SELECT * FROM {table_name} WHERE {Column1} LIKE @nameLine";
            try
            {
                // Ejecutar la consulta utilizando parámetros
                return queryManager.ExecuteSelectQuery(query, new Dictionary<string, object>
        {
            { "@nameLine", $"%{nameline}%" } // Utilizamos % para que coincida con cualquier parte del nombre de la línea
        });
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                MessageBox.Show($"Error al buscar la línea de producción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void DeleteLineProduction(string nameLine)
        {
            string query = $"DELETE FROM {table_name} WHERE {Column1} = @nameLine";
            try
            {
                int rowsAffected = queryManager.ExecuteNonQuery(query, new Dictionary<string, object>
        {
            { "@nameLine", nameLine }
        });

                if (rowsAffected > 0)
                {
                    MessageBox.Show("La línea de producción se ha eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la línea de producción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la línea de producción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

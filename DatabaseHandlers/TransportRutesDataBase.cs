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
    public class TransportRutesDataBase
    {
        private MySQLQueryManager queryManager;
        private const string table_name = "rutes";
        private const string column1 = "rute_num";
        private const string column2 = "decription";


        internal TransportRutesDataBase(MySQLQueryManager queryManager)
        {
            this.queryManager = queryManager;
        }

        public DataTable GetDataTransportRute()
        {
            string query = $"SELECT * FROM {table_name}";
            return queryManager.ExecuteSelectQuery(query);
        }

        public void AddRow(int ColumnNumberTxtb, string ColumnDescriptionTxb)
        {
           
            string query = $"INSERT INTO {table_name} ({column1}, {column2}) VALUES (@NumberLine, @Description)";

            try
            {
                // Ejecutar la consulta utilizando parámetros
                int rowsAffected = queryManager.ExecuteNonQuery(query,
                    new Dictionary<string, object>
                    {
                { "@NumberLine", ColumnNumberTxtb},
                { "@Description", ColumnDescriptionTxb }
                    });

                // Verificar si la inserción fue exitosa
                if (rowsAffected > 0)
                {
                    MessageBox.Show("La ruta de transporte ha agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la ruta de transporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la ruta de transporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable SearchTransportRute(string nameTransport)
        {
            string query = $"SELECT * FROM {table_name} WHERE {column2} LIKE @nameLine";
            try
            {
                // Ejecutar la consulta utilizando parámetros
                return queryManager.ExecuteSelectQuery(query, new Dictionary<string, object>
        {
            { "@nameLine", $"%{nameTransport}%" } // Utilizamos % para que coincida con cualquier parte del nombre de la línea
        });
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                MessageBox.Show($"Error al buscar la línea de producción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
         
            }
        }

        public void DeleteTransportRute(string nameLine)
        {
            string query = $"DELETE FROM {table_name} WHERE {column2} = @nameLine";
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

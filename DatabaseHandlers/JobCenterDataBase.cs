using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PEASA_App
{
    public class JobCenterDataBase
    {

        private MySQLQueryManager queryManager;
        private const string table_name = "machine";
        private const string col1 = "serial_num";
        private const string col2 = "description";
        private const string col3 = "id_line";
        private const string col4 = "personnel_required";
        private const string col5 = "personnel_active";


        internal JobCenterDataBase(MySQLQueryManager queryManager)
        {
            this.queryManager = queryManager;
        }

        public DataTable GetJobCenterTable()
        {
            string query = $@"
        SELECT 
            m.serial_num, 
            m.description, 
            l.name AS name, 
            m.personnel_required, 
            m.personnel_active
        FROM {table_name} m
        INNER JOIN Line l ON m.id_line = l.id";
            return queryManager.ExecuteSelectQuery(query);

        }

        public void AddJobCenter(string serial_num, string description, int id_line, int requieredPersonal, int activePersonal)
        {
            string query = $"INSERT INTO {table_name} ({col1}, {col2}, {col3}, {col4}, {col5}) VALUES (@serial_num, @description, @id_line, @requieredPersonal, @activePersonal)";
            try
            {
                // Ejecutar la consulta utilizando parámetros
                int rowsAffected = queryManager.ExecuteNonQuery(query, new Dictionary<string, object>
        {
                    { "@serial_num", serial_num },
                    {"@description", description },
                    {"@id_line", id_line},
                    { "@requieredPersonal", requieredPersonal},
                    { "@activePersonal", activePersonal}

        });

                // Verificar si la inserción fue exitosa
                if (rowsAffected > 0)
                {
                    MessageBox.Show("El centro de trabajo se ha agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el centro de trabajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                MessageBox.Show($"Error al agregar el centro de trabajo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteJobCenter(string nameMachine)
        {
            string query = $"DELETE FROM {table_name} WHERE {col1} = @nameLine";
            try
            {
                int rowsAffected = queryManager.ExecuteNonQuery(query, new Dictionary<string, object>
        {
            { "@nameLine", nameMachine }
        });

                if (rowsAffected > 0)
                {
                    MessageBox.Show("El centro de trabajo se ha eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el centro de trabajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el centro de trabajo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable SearchCenterNumber(string numberCenter)
        {
            string query = $"SELECT * FROM {table_name} WHERE {col1} LIKE @serial_num";
            try
            {
                
                // Ejecutar la consulta utilizando parámetros
                return queryManager.ExecuteSelectQuery(query, new Dictionary<string, object>
        {
            { "@serial_num", $"%{numberCenter}%" } // Utilizamos % para que coincida con cualquier parte del nombre de la línea
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

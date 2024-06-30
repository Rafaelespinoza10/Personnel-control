using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Windows.Forms;

namespace PEASA_App
{
    internal class AttandanceDataBase
    {
        private MySQLQueryManager queryManager;
        private const string table_name = "workers_attendance";
        private const string column1 = "id_worker";
        private const string column2 = "date";
        private const string column3 = "status";

        internal AttandanceDataBase(MySQLQueryManager queryManager)
        {
            this.queryManager = queryManager;
        }

        

        public void InsertAttendance(int worker_id, DateTime date, string status)
        {
            string query = $"INSERT INTO {table_name} ({column1},{column2},{column3}) VALUES (@id_worker, @date, @status)";
            
            try
            {
                // Ejecutar la consulta utilizando parámetros
                int rowsAffected = queryManager.ExecuteNonQuery(query, new Dictionary<string, object>
        {
                    { "@id_worker",worker_id},
                    { "@date", date},
                    { "@status", status},
                    
        });

                
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                MessageBox.Show($"Error al agregar la asistencia del trabajador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}

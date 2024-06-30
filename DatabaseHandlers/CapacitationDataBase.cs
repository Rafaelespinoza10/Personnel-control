using PEASA_App.Clases; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PEASA_App
{

    internal class CapacitationDataBase
    {
        private const string table_name = "capacitation";
        private const string col2 = "safety_training";
        private const string col3 = "safety_training_score";
        private const string col4 = "safety_training_date";
        private const string col5 = "tuning_training";
        private const string col6 = "tuning_training_score";
        private const string col7 = "tuning_training_date";
        private const string col8 = "production_report";
        private const string col9 = "production_report_score";
        private const string col10 = "production_report_date";
        private const string col11 = "operation_conditions";
        private const string col12 = "operation_conditions_score";
        private const string col13 = "operation_conditions_date";
        private const string col14 = "self_maintenance_checklist";
        private const string col15 = "self_maintenance_checklist_score";
        private const string col16 = "self_maintenance_checklist_date";
        private const string col17 = "use_of_stilt";
        private const string col18 = "use_of_stilt_score";
        private const string col19 = "use_of_stilt_date";
        private const string col20 = "measurement_instruments";
        private const string col21 = "measurement_instruments_score";
        private const string col22 = "measurement_instruments_date";
        private const string col23 = "non_conforming_product_control";
        private const string col24 = "non_conforming_product_control_score";
        private const string col25 = "non_conforming_product_control_date";
        private const string col26 = "inspection_sheet";
        private const string col27 = "inspection_sheet_score";
        private const string col28 = "inspection_sheet_date";



        private MySQLQueryManager queryManager;

        internal CapacitationDataBase(MySQLQueryManager queryManager)
        {
            this.queryManager = queryManager;
        }

        public DataTable GetCapacitationTable()

        {

            string query = $"SELECT  w.short_nomina As Nomina, w.name AS NombreTrabajador, {col2} AS GeneralidadesSeguridad, " +
               $"{col3} AS Calificación, {col4} AS Fecha, " +
               $"{col5} AS PuestaPunto, {col6} AS Calificación, {col7} AS Fecha, " +
               $"{col8} AS ReporteProduccion, {col9} AS Calificación, {col10} AS Fecha, " +
               $"{col11} AS CondicionesOperacion, {col12} AS Calificación, {col13} AS Fecha, " +
               $"{col14} AS Checklist, {col15} AS Calificación, {col16} AS Fecha, " +
               $"{col17} AS UsoEscantillon, {col18} AS Calificación, {col19} AS Fecha, " +
               $"{col20} AS InstrumentosMedición, {col21} AS Calificación, {col22} AS Fecha, " +
               $"{col23} AS ControlProdNoConforme, {col24} AS Calificación, {col25} AS Fecha, " +
               $"{col26} AS HojaAutoInspección, {col27} AS Calificación, {col28} AS Fecha " +
               $"FROM {table_name} c " +
               $"INNER JOIN workers w ON c.id_worker = w.id";


            return queryManager.ExecuteSelectQuery(query);

        }


        public int ObtainID(string searchvalue, string name_column, string NameTable)
        {

            int id = -1; // Valor predeterminado en caso de que no se encuentre la línea

            string query = $"SELECT id FROM {NameTable} WHERE {name_column} = '{searchvalue}'";

            try
            {

                DataTable result = queryManager.ExecuteSelectQuery(query);

                if (result != null && result.Rows.Count > 0)
                {
                    // Obtener el valor del ID de la primera fila encontrada
                    id = Convert.ToInt32(result.Rows[0]["id"]);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la consulta
                MessageBox.Show($"Error al obtener el ID del trabajador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;

        }

        public void InsertCapacitation(int workerId, string capacitation, int calification, DateTime dateCapacitation)
        {
            string query = $"UPDATE {table_name} SET " +
                           $"{capacitation} = 1, " +
                           $"{capacitation}_score = @calification, " +
                           $"{capacitation}_date = @dateCapacitation " +
                           $"WHERE id_worker = @workerId";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@workerId", workerId);
            parameters.Add("@calification", calification);
            parameters.Add("@dateCapacitation", dateCapacitation.ToString("yyyy-MM-dd"));

            try
            {
                int rowsAffected = queryManager.ExecuteNonQuery(query, parameters);
                // Comprobar si la consulta afectó alguna fila
                if (rowsAffected > 0)
                {
                    MessageBox.Show("La capacitación se ha registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la capacitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar la capacitación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

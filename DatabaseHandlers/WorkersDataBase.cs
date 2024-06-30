using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;


namespace PEASA_App
{
    internal class WorkersDataBase
    {
        private MySQLQueryManager queryManager;
        private const string table_name = "workers";
        private const string col1 = "name";
        private const string col2 = "nomina";
        private const string col3 = "short_nomina";
        private const string col4 = "join_date";
        private const string col5 = "gender";
        private const string col6 = "id_machine";
        private const string col7 = "id_gerente";
        private const string col8 = "id_rute";
        private const string col9 = "active";
        private const string col10 = "incapacitated";
        private const string col11 = "id_area";
        private const string col12 = "age"; // fecha de nacimiento
        private const string col13 = "seniority";
        private const string col14 = "exit_reason";
        private const string col15 = "exit_date";
        private const string col16 = "leave_worker";
        private const string col17 = "shift"; // turno de trabajo
        private const string col18 = "category";  // categoria
        private const string col19 = "education"; // escolaridad
        private const string col20 = "weight"; // peso
        private const string col21 = "height"; // estatura
        private const string col22 = "origin"; // lugar de procedencia
        private const string col23 = "parent"; // si es padre o madre
        private const string col24 = "date_of_birth"; //fecha de nacimiento

    

        internal WorkersDataBase(MySQLQueryManager queryManager)
        {
            this.queryManager = queryManager;
        }

        public DataTable GetWorkersData()
        {
            string query = $"SELECT  w.name, w.short_nomina, w.nomina, a.name AS area_name, r.decription AS rutes_description , w.join_date,w.category, w.education, w.origin, w.parent, w.age,  w.acitve, w.incapacitated, w.leave_worker " +
               $"FROM {table_name} w " +
               $"LEFT JOIN Areas a ON w.id_area = a.id " +
               $"LEFT JOIN Rutes r ON w.id_rute = r.id";
            return queryManager.ExecuteSelectQuery(query);

        }

        public DataTable GetEstampadosList()
        {
            string query = $"SELECT  w.name, w.short_nomina, w.nomina, a.name AS area_name, g.name AS gerents_name,  r.decription AS rutes_description , w.join_date, w.gender, m.serial_num AS NumberCenter, w.acitve, w.incapacitated, w.age " +
                $"FROM {table_name} w " +
                $"LEFT JOIN Gerents g ON w.id_gerente = g.id " + 
                $"LEFT JOIN Machine m ON w.id_machine = m.id " +
                $"LEFT JOIN Areas a ON w.id_area = a.id " +
                $"LEFT JOIN Rutes r ON w.id_rute = r.id " +
                $"WHERE a.name = 'Estampados'";

            return queryManager.ExecuteSelectQuery(query);

        }

        public DataTable GetAttandanceEstampadosList()
        {
            string query = $"SELECT  w.name, w.short_nomina, w.nomina, a.name AS area_name, g.name AS gerents_name, m.serial_num AS NumberCenter, w.acitve, w.incapacitated " +
                $"FROM {table_name} w " +
                $"LEFT JOIN Gerents g ON w.id_gerente = g.id " +
                $"LEFT JOIN Machine m ON w.id_machine = m.id " +
                $"LEFT JOIN Areas a ON w.id_area = a.id " +
                $"WHERE a.name = 'Estampados' AND g.name = 'marcos.narciso' AND w.acitve = 1";

            return queryManager.ExecuteSelectQuery(query);
        }

        public DataTable GetAttandanceEstampadosList2()
        {
            string query = $"SELECT  w.name, w.short_nomina, w.nomina, a.name AS area_name, g.name AS gerents_name, m.serial_num AS NumberCenter, w.acitve, w.incapacitated " +
                $"FROM {table_name} w " +
                $"LEFT JOIN Gerents g ON w.id_gerente = g.id " +
                $"LEFT JOIN Machine m ON w.id_machine = m.id " +
                $"LEFT JOIN Areas a ON w.id_area = a.id " +
                $"WHERE a.name = 'Estampados' AND g.name = 'oscar.armendariz' AND w.acitve = 1";

            return queryManager.ExecuteSelectQuery(query);
        }


        public DataTable GetAttandanceSoldaduraList()
        {
            string query = $"SELECT w.name, w.short_nomina, w.nomina, a.name AS area_name, g.name AS gerents_name, m.serial_num AS NumberCenter, l.name AS LineProduction, w.acitve, w.incapacitated " +
                         $"FROM {table_name} w " +
                         $"LEFT JOIN Gerents g ON w.id_gerente = g.id " +
                         $"LEFT JOIN Machine m ON w.id_machine = m.id " +
                         $"LEFT JOIN Line l ON m.id_line = l.id " +
                         $"LEFT JOIN Areas a ON w.id_area = a.id " +
                         $"WHERE a.name IN ('Soldadura', 'Punteo') AND g.name = 'osvaldo.andraca' AND w.acitve = 1";

            return queryManager.ExecuteSelectQuery(query);
        }

        public DataTable GetAttandanceSoldaduraList2()
        {
            string query = $"SELECT w.name, w.short_nomina, w.nomina, a.name AS area_name, g.name AS gerents_name, m.serial_num AS NumberCenter, l.name AS LineProduction, w.acitve, w.incapacitated " +
                         $"FROM {table_name} w " +
                         $"LEFT JOIN Gerents g ON w.id_gerente = g.id " +
                         $"LEFT JOIN Machine m ON w.id_machine = m.id " +
                         $"LEFT JOIN Line l ON m.id_line = l.id " +
                         $"LEFT JOIN Areas a ON w.id_area = a.id " +
                         $"WHERE a.name IN ('Soldadura', 'Punteo') AND g.name = 'david.aranda' AND w.acitve = 1";

            return queryManager.ExecuteSelectQuery(query);
        }


        public DataTable GetAttandanceSoldaduraList3()
        {
            string query = $"SELECT w.name, w.short_nomina, w.nomina, a.name AS area_name, g.name AS gerents_name, m.serial_num AS NumberCenter, l.name AS LineProduction, w.acitve, w.incapacitated " +
                         $"FROM {table_name} w " +
                         $"LEFT JOIN Gerents g ON w.id_gerente = g.id " +
                         $"LEFT JOIN Machine m ON w.id_machine = m.id " +
                         $"LEFT JOIN Line l ON m.id_line = l.id " +
                         $"LEFT JOIN Areas a ON w.id_area = a.id " +
                         $"WHERE a.name IN ('Soldadura', 'Punteo') AND g.name = 'oscar.jara' AND w.acitve = 1";

            return queryManager.ExecuteSelectQuery(query);
        }

        public DataTable GetSoldaduraList()
        {
            string query = $"SELECT  w.name, w.short_nomina, w.nomina, a.name AS area_name, g.name AS gerents_name,  r.decription AS rutes_description , w.join_date, w.gender, m.serial_num AS NumberCenter, w.acitve, w.incapacitated, w.age " +
                $"FROM {table_name} w " +
                $"LEFT JOIN Gerents g ON w.id_gerente = g.id " +
                $"LEFT JOIN Machine m ON w.id_machine = m.id " +
                $"LEFT JOIN Areas a ON w.id_area = a.id " +
                $"LEFT JOIN Rutes r ON w.id_rute = r.id " +
                $"WHERE a.name IN ('Soldadura', 'Punteo')";
            return queryManager.ExecuteSelectQuery(query);
        }

        public void AddWorkerHumanResources(string name, string nomina, string short_nomina, DateTime date, DateTime birthDate, string gender, int rute, int WorkArea, string education, string origin, bool parentsBool, int age)
        {
            string query = $"INSERT INTO {table_name} ({col1}, {col2}, {col3}, {col4}, {col24}, {col5}, {col8}, {col11}, {col19},{col22}, {col23}, {col12}) VALUES (@name, @nomina, @short_nomina,@join_date, @date_of_birth, @gender, @id_rute, @id_area,@education, @origin, @parent, @age)";
            try
            {
                // Ejecutar la consulta utilizando parámetros
                int rowsAffected = queryManager.ExecuteNonQuery(query, new Dictionary<string, object>
        {
                    { "name",name },
                    { "nomina", nomina},
                    { "short_nomina", short_nomina},
                    { "join_date", date},
                    { "date_of_birth", birthDate },
                    {"gender", gender },
                    { "id_rute", rute},
                    { "id_area", WorkArea},
                    {"education", education },
                    { "origin", origin },
                    {"parent", parentsBool },
                    { "age", age}

        });

                // Verificar si la inserción fue exitosa
                if (rowsAffected > 0)
                {
                    MessageBox.Show("El trabajador se ha agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el trabajador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                MessageBox.Show($"Error al agregar el trabajador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public int ObtainGerent(string searchValue, string name_column, string NameTable)
        {
            int id = -1; // Valor predeterminado en caso de que no se encuentre la línea

            string query = $"SELECT id FROM {NameTable} WHERE {name_column} = @searchValue";

            try
            {
                // Crear un diccionario de parámetros
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@searchValue", searchValue);

                DataTable result = queryManager.ExecuteSelectQuery(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    // Obtener el valor del ID de la primera fila encontrada
                    id = Convert.ToInt32(result.Rows[0]["id"]);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la consulta
                MessageBox.Show($"Error al obtener el ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;

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

        public void UpdateWorkerCenter(string nomina_short, int workerCenter, int gerentID)
        {
            string query = "UPDATE workers SET id_machine = @workerCenter, id_gerente = @gerentID  WHERE short_nomina = @nomina_short";
            try
            {
                // Crear un diccionario de parámetros
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@workerCenter", workerCenter);
                parameters.Add("@nomina_short", nomina_short);
                parameters.Add("@gerentID", gerentID);

                // Ejecutar la consulta para actualizar el centro de trabajo del trabajador
                int rowsAffected = queryManager.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    // Actualización exitosa
                    MessageBox.Show($"El centro de trabajo del trabajador con nómina {nomina_short} se ha actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // No se encontró el trabajador con la nómina especificada
                    MessageBox.Show($"No se encontró ningún trabajador con la nómina {nomina_short}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el centro de trabajo del trabajador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void updateIncapacitatedStatus(string nomina_short, bool incapacitated, int  activeStatus)
        {
                 activeStatus = incapacitated ? 0 : 1; // si esta incapacitado 
            
            int incapacitatedStatus = activeStatus == 1 ? 0 : 1;

            string query = "UPDATE Workers SET incapacitated = @incapacitated, acitve = @active WHERE short_nomina = @nomina_short";
            try
            {

                // Crear un diccionario de parámetros
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@incapacitated", incapacitatedStatus);
                parameters.Add("@active", activeStatus);
                parameters.Add("@nomina_short", nomina_short);

                int rowsAffected = queryManager.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    // Actualización exitosa
                    MessageBox.Show($"El estado de la incapacidad del trabajador con nómina {nomina_short} se ha actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // No se encontró el trabajador con la nómina especificada
                    MessageBox.Show($"No se encontró ningún trabajador con la nómina {nomina_short}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el estado de la incapacidad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void UpdateLeaveStatusAndAddReason(string short_nomina, bool leave, bool incapacitated, int activeStatus, string reason, DateTime dateExit)
        {
            try
            {
                // Determinar el estado de activo e incapacitado
                activeStatus = leave ? 0 : 1;
                incapacitated = leave ? false : true;

                // Determinar el estado de baja
                int leaveStatus = (activeStatus == 1 || incapacitated == true) ? 0 : 1;

                // Actualizar la base de datos
                string query = $"UPDATE {table_name} SET acitve = @active, incapacitated = @incapacitated, leave_worker = @leave, {col14} = @reason, {col15} = @exitDate WHERE {col3} = @short_nomina";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@active", activeStatus);
                parameters.Add("@incapacitated", incapacitated);
                parameters.Add("@leave", leaveStatus);
                parameters.Add("@reason", reason);
                parameters.Add("@exitDate", dateExit);
                parameters.Add("@short_nomina", short_nomina);

                int rowsAffected = queryManager.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    // Actualización exitosa
                    MessageBox.Show($"Se ha actualizado el estado del trabajador con nómina {short_nomina} correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // No se encontró el trabajador con la nómina especificada
                    MessageBox.Show($"No se encontró ningún trabajador con la nómina {short_nomina}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el estado de baja: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchWorkers(string short_nomina, string name)
        {
            string query = $"SELECT * FROM {table_name} WHERE {col3} LIKE @short_nomina AND {col1} LIKE @name";
            try
            {
                // Ejecutar la consulta utilizando parámetros
                
                return queryManager.ExecuteSelectQuery(query, new Dictionary<string, object>
        {
              { "@short_nomina", $"%{short_nomina}%" },
            { "@name", $"%{name}%" }
                
        });
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la ejecución de la consulta
                MessageBox.Show($"Error al buscar el trabajador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

       

    }

}

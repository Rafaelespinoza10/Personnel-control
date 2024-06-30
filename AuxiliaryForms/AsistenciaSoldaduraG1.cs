using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public partial class AsistenciaSoldaduraG1 : Form
    {
        MySQLConnectionManager connectionManager;
        MySQLQueryManager queryManager;
        WorkersDataBase workersDataBase;
        private bool comboBoxesAdded = false; // Declarar una bandera para indicar si las columnas de ComboBoxes se han agregado
        AttandanceDataBase attandanceDataBase;


        public AsistenciaSoldaduraG1(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = new MySQLQueryManager(connectionManager.GetConnection()); // Inicializar
            this.workersDataBase = new WorkersDataBase(queryManager);
            this.attandanceDataBase = new AttandanceDataBase(queryManager);

            // Desactivar la adición de filas automáticas
            dgv_AttendanceList1.AllowUserToAddRows = false;
            dgv_AttendanceList1.CellEndEdit += dgv_AttendanceList1_CellEndEdit;

        }

        private void dgv_AttendanceList1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgv_AttendanceList1.Columns[e.ColumnIndex].Name == "Attendance")
            {
                DataGridViewComboBoxCell comboBoxCell = dgv_AttendanceList1.Rows[e.RowIndex].Cells["Attendance"] as DataGridViewComboBoxCell;
                if (comboBoxCell != null && comboBoxCell.Value != null)
                {
                    string selectedValue = comboBoxCell.Value.ToString();
                }
            }
        }

        private void AsistenciaSoldaduraG1_Load(object sender, EventArgs e)
        {
            if (!comboBoxesAdded) // Verificar si las columnas de ComboBoxes aún no se han agregado
            {
                MostrarListaTrabajadores(); // Mostrar la lista de trabajadores y agregar las columnas de ComboBoxes
                comboBoxesAdded = true; // Establecer la bandera como verdadera después de agregar las columnas de ComboBoxes
            }
        }

        private void MostrarListaTrabajadores()
        {
            try
            {
                DataTable workersData = workersDataBase.GetAttandanceSoldaduraList();

                dgv_AttendanceList1.DataSource = workersData;

                // Verificar si hay trabajadores en la lista antes de agregar la columna de ComboBox
                if (workersData.Rows.Count > 0 && dgv_AttendanceList1.Columns["Attendance"] == null)
                {
                    DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                    comboBoxColumn.HeaderText = "Attendance";
                    comboBoxColumn.Name = "Attendance";
                    comboBoxColumn.Items.AddRange("A", "F", "V", "I", "TXT", "PSG");

                    comboBoxColumn.DefaultCellStyle.NullValue = "A";

                    dgv_AttendanceList1.Columns.Add(comboBoxColumn);
                }

                foreach (DataGridViewRow row in dgv_AttendanceList1.Rows)
                {
                    if (row.Cells["Attendance"].Value == null || string.IsNullOrEmpty(row.Cells["Attendance"].Value.ToString()))
                    {
                        row.Cells["Attendance"].Value = "A";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la lista de trabajadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ConfirmarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dt_dateAttendance.Value;

                foreach (DataGridViewRow row in dgv_AttendanceList1.Rows)
                {
                    if (!row.IsNewRow) // Ignorar la fila de nueva inserción
                    {
                        string workerName = Convert.ToString(row.Cells["name"].Value);
                        object attendanceValue = row.Cells["Attendance"].Value;

                        // Verificar si el valor de la asistencia es nulo
                        if (attendanceValue == null)
                        {
                            attendanceValue = "A";
                        }

                        if (attendanceValue != null)
                        {
                            string status = attendanceValue.ToString();
                            int workerId = workersDataBase.ObtainGerent(workerName, "name", "Workers");

                            //abrir conexion 
                            this.connectionManager.OpenConnection();
                            // Insertar la asistencia en la base de datos
                            attandanceDataBase.InsertAttendance(workerId, date, status);
                        }
                    }
                }
                MessageBox.Show("Asistencia registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la asistencia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

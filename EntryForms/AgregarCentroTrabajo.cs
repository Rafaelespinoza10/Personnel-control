using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public partial class AgregarCentroTrabajo : Form
    {
        //private MySQLQueryManager queryManager;
        private JobCenterDataBase jobCenterDataBase;
        private MySQLQueryManager queryManager;
        private MySQLConnectionManager connectionManager;
        public event EventHandler<CentroTrabajoEvents> NewJobCenter;
        
        protected virtual void OnJobCenterAdd(CentroTrabajoEvents e)
        {
            NewJobCenter ?.Invoke(this, e);
        }


        public AgregarCentroTrabajo(MySQLConnectionManager connectionManager)
        {

            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = new MySQLQueryManager(connectionManager.GetConnection()); // Inicializar
            this.jobCenterDataBase = new JobCenterDataBase(queryManager);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       

        private int ObtainIDLineProduction(string productionLine)
        {

            int lineID = -1; // Valor predeterminado en caso de que no se encuentre la línea

            string query = $"SELECT id FROM Line WHERE name = '{productionLine}'";

            try
            {

                DataTable result = queryManager.ExecuteSelectQuery(query);

                // Verificar si se encontró una línea con el nombre especificado
                if (result != null && result.Rows.Count > 0)
                {
                    // Obtener el valor del ID de la primera fila encontrada
                    lineID = Convert.ToInt32(result.Rows[0]["id"]);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la consulta
                MessageBox.Show($"Error al obtener el ID de la línea de producción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lineID;

        }

        private void btn_AddNewJobCenter_Click(object sender, EventArgs e)
        {
            connectionManager.OpenConnection();
            try
            {
                string centerNumber = Txt_centerNumber.Text;
                string description = txt_description.Text;
                string productionLine = txt_productionLine.Text;
                string requiredPersonnel = txt_requieredPersonnel.Text;
                string activePersonnel = txt_activePersonnel.Text;

                if (!string.IsNullOrEmpty(centerNumber) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(productionLine) && !string.IsNullOrEmpty(requiredPersonnel) )
                {
                    int id_Line = ObtainIDLineProduction(productionLine);
                    int numberRequieredPersonal = Convert.ToInt32(requiredPersonnel);
                    int numberActivePersonal = Convert.ToInt32(activePersonnel);

                    jobCenterDataBase.AddJobCenter(centerNumber, description, id_Line, numberRequieredPersonal, numberActivePersonal);

                    // Actualizar la vista de las líneas de producción
                    OnJobCenterAdd(new CentroTrabajoEvents(centerNumber, description, id_Line, numberRequieredPersonal, numberActivePersonal));

                }
                else
                {
                    MessageBox.Show("Por favor, llene todos los campos para agregar el centro de trabajo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el centro de trabajo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Txt_centerNumber.Text = "";
            txt_description.Text = "";
            txt_productionLine.Text = "";
            txt_requieredPersonnel.Text = "";
            txt_activePersonnel.Text = ""; 
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

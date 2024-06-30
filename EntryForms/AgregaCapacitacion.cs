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
    public partial class AgregaCapacitacion : Form
    {

        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        private CapacitationDataBase capacitationDataBase;
        public event EventHandler<CapacitationEvents> NewCapacitation;
        public AgregaCapacitacion(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = new MySQLQueryManager(connectionManager.GetConnection());
            this.capacitationDataBase = new CapacitationDataBase(queryManager);
        }
        protected virtual void OnCapacitation(CapacitationEvents e) // agregar workerEvents
        {
            NewCapacitation?.Invoke(this, e);
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

    


        private string obtainCapacitation(string capacitation)
        {

            string CapacitationDB = ""; 

            switch (capacitation)
            {
                case "Generalidades de seguridad":
                     CapacitationDB = "safety_training";    
                    break;
                case "Puesta a punto":
                    CapacitationDB = "tuning_training";
                    break;
                case "Reporte de producción":
                    CapacitationDB = "production_report";
                    break;

                case "Condiciones de Operación":
                    CapacitationDB = "operation_conditions";
                    break;
                case "Automantenimiento CheckList":
                    CapacitationDB = "self_maintenance_checklist";
                    break;
                case "Uso de escantillones":
                    CapacitationDB = "use_of_stilt";
                    break;
                case "Instrumentos de medición":
                    CapacitationDB = "measurement_instruments";
                    break;
                case "Control de producto no conforme":
                    CapacitationDB = "non_conforming_product_control";
                    break;
                case "Hoja de autoinspección":
                    CapacitationDB = "inspection_sheet";
                    break;
                default:
                    break;

            }
            return CapacitationDB;
        }
        
            
        

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddNewCapacitation_Click_1(object sender, EventArgs e)
        {
            connectionManager.OpenConnection();
            try
            {
                string short_nomina = txt_nomina.Text;
                string capacitation = cb_capacitacion.Text;
                string calification = tx_calificacion.Text;
                DateTime capacitation_date = dt_fecha.Value;

                if (!string.IsNullOrEmpty(short_nomina) && !string.IsNullOrEmpty(capacitation) && !string.IsNullOrEmpty(calification))
                {

                    //          bool capacitationBool = obtainCapacitation(capacitation);
                    string capacitationDB = obtainCapacitation(capacitation);
                    int calificationInteger = Int32.Parse(calification);
                    int short_nominaInteger = capacitationDataBase.ObtainID(short_nomina, "short_nomina", "workers");

                    MessageBox.Show("el id del trabajador es: " + $"{short_nominaInteger}");

                    capacitationDataBase.InsertCapacitation(short_nominaInteger, capacitationDB, calificationInteger, capacitation_date);
                    OnCapacitation(new CapacitationEvents(short_nominaInteger, true, calificationInteger, capacitation_date));
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre para la nueva área de trabajo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el área de trabajo {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

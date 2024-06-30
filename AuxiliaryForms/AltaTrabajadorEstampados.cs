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
    public partial class AltaTrabajadorEstampados : Form
    {
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        private WorkersDataBase workersDataBase;
        public event EventHandler<TrabajadorEvents> NewWorkerEstampados;

        protected virtual void OnWorkerAdd(TrabajadorEvents e) // agregar workerEvents
        {
            NewWorkerEstampados?.Invoke(this, e);
        }

        public AltaTrabajadorEstampados(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = new MySQLQueryManager(connectionManager.GetConnection()); // Inicializar
            this.workersDataBase = new WorkersDataBase(queryManager);
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

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private int ObtainGerentID(string gerent)
        {
            // Diccionario para mapear nombres de supervisores con sus IDs
            Dictionary<string, string> gerentMap = new Dictionary<string, string>
            {
                { "Marcos Narciso", "marcos.narciso" },
                { "Oscar Armendariz", "oscar.armendariz" }
      
            };

            if (gerentMap.ContainsKey(gerent))
            {
                string gerentUser = gerentMap[gerent];
                return workersDataBase.ObtainGerent(gerentUser, "name", "Gerents");
            }
            else
            {
                MessageBox.Show($"Nombre de supervisor no válido: {gerent}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Valor predeterminado si el nombre del supervisor no es válido
            }
        }

        private void btn_AddEstampadosWorker_Click(object sender, EventArgs e)
        {
            connectionManager.OpenConnection();

            try
            {
                string nomina = txt_nomina.Text;
                string largue_nomina = txt_largeNomina.Text;
                string workCenter = txt_workCenter.Text;
                string gerent = cb_supervisor.Text; 


                if(!string.IsNullOrEmpty(nomina) && !string.IsNullOrEmpty(largue_nomina) && !string.IsNullOrEmpty(workCenter) && !string.IsNullOrEmpty(gerent))
                {

                    int workerCenterNumber = workersDataBase.ObtainID(workCenter, "serial_num", "machine");
                    int gerentID = ObtainGerentID(gerent);
                    // Ahora se edita la informacion para actualizar el centro de trabajo del. 

                    if(workerCenterNumber !=-1 && gerentID != -1)
                    {
                    workersDataBase.UpdateWorkerCenter(nomina, workerCenterNumber, gerentID);
                    OnWorkerAdd(new TrabajadorEvents(nomina, workerCenterNumber, gerentID));
                   
                    }
                }

            }catch(Exception ex) {

                MessageBox.Show($"Error al dar de alta el c.t. al trabajador de estampados. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cb_supervisor.Text = string.Empty;
        }
    }
}

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
    public partial class Bajas : Form
    {
        private WorkersDataBase workersDataBase;
        private MySQLQueryManager queryManager;
        private MySQLConnectionManager connectionManager;
        public event EventHandler<TrabajadorEvents> NewLeave;
        public bool LeaveWorker = false;

        protected virtual void OnIncapacitedAdd(TrabajadorEvents e) // agregar workerEvents
        {
            NewLeave?.Invoke(this, e);
        }


        public Bajas(MySQLConnectionManager connectionManager)
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
        
        
        
        private void UpdateLeaveStatus(bool leaveWorker)
        {
            try
            {
                string name = txb_Name.Text;
                string nomina = txt_nomina.Text;
                string largue_nomina = txt_largeNomina.Text;
                string reasonExit = txt_reasonExit.Text;
                DateTime ExitDate = dtp_ExitDate.Value;


                int activeStatus = 1;
                bool incapacitated = false; 


                workersDataBase.UpdateLeaveStatusAndAddReason(nomina,leaveWorker,incapacitated,activeStatus,reasonExit, ExitDate);
                // se edita la informacion del trabajador. 

               OnIncapacitedAdd(new TrabajadorEvents(nomina, leaveWorker, activeStatus, incapacitated, reasonExit, ExitDate));

            }
            catch (Exception er)
            {
                MessageBox.Show($"No se encuentra informacion del trabajador: {er.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        
        private void btn_ConfirmLeave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que se quiere dar de baja al trabajador?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            // Verifica la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                UpdateLeaveStatus(true);
            }
            else
            {
                UpdateLeaveStatus(false);
            }
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

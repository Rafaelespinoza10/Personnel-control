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
    public partial class Incapacidades : Form
    {
        private WorkersDataBase workersDataBase;
        private MySQLQueryManager queryManager;
        private MySQLConnectionManager connectionManager;
        public event EventHandler<TrabajadorEvents> NewIncapacity;
        public bool incapacitaded = false; 

        protected virtual void OnIncapacitedAdd(TrabajadorEvents e) // agregar workerEvents
        {
            NewIncapacity?.Invoke(this, e);
        }


        public Incapacidades(MySQLConnectionManager connectionManager)
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

        private void panelTitle_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void rbtn_DarAltaIncapacidad_CheckedChanged(object sender, EventArgs e)
        {
            incapacitaded = true;
        }

        private void btn_DarBajaIncapacidad_CheckedChanged(object sender, EventArgs e)
        {
            incapacitaded = false;
        }

        private void btn_addOrQuitIncapacited_Click(object sender, EventArgs e)
        {

            if (incapacitaded)
            {
                     UpdateIncapacitatedStatus(true);
 
            }
            else
            {
                 UpdateIncapacitatedStatus(false);
            
            }

        }

        private void UpdateIncapacitatedStatus(bool incapacitated)
        {
            try
            {
                string name = txb_Name.Text;
                string nomina = txt_nomina.Text;
                string largue_nomina = txt_largeNomina.Text;
                int activeStatus = 0;

                if (!string.IsNullOrEmpty(nomina) && !string.IsNullOrEmpty(largue_nomina) && !string.IsNullOrEmpty(name))
                {
                    workersDataBase.updateIncapacitatedStatus(nomina, incapacitated, activeStatus);
                    // se edita la informacion del trabajador. 

                    OnIncapacitedAdd(new TrabajadorEvents(nomina, activeStatus,  incapacitated));


                }

            }catch(Exception er)
            {
                MessageBox.Show($"No se encuentra informacion del trabajador: {er.Message}", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

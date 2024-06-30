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
    public partial class AgregarTiempoExtra : Form
    {
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        private ExtraTimeDataBase extraTimeDataBase;
        private  EventHandler<ExtraTimeEvents> NewExtraTime;

        public AgregarTiempoExtra(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = new MySQLQueryManager(connectionManager.GetConnection());
            this.extraTimeDataBase = new ExtraTimeDataBase(queryManager);
        }
        /*
        protected virtual void OnExtraTime(ExtraTimeEvents e)
        {
            NewExtraTime?.Invoke(this, e);

        }
        */


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

        private void btn_AddNewExtraTime_Click(object sender, EventArgs e)
        {
            string short_nomina = txt_nomina.Text;
            string workArea = cb_areaTrabajo.Text;
            string turne = tx_turno.Text;
            DateTime extraTimeDate = dt_fechaRegistro.Value;
            string hoursWorks = txt_HorasTrabajo.Text;
            string numberPart = txt_np.Text;
            string gerent = cb_supervisor.Text;
            string route = cb_ruta.Text;

            if(!string.IsNullOrEmpty(short_nomina)&& !string.IsNullOrEmpty(workArea) && !string.IsNullOrEmpty(turne) && !string.IsNullOrEmpty(hoursWorks) && !string.IsNullOrEmpty(gerent) && !string.IsNullOrEmpty(route))
            {
                /*
                string workAreaDB = extraTimeDataBase.ObtainID(workArea, "");
                string short_nominaID = extraTimeDataBase.ObtainID(short_nomina);
                string numberPart = extraTimeDataBase()
                */
            }

        }
    }
}

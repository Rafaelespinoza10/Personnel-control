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
    public partial class AgregarTrabajador : Form
    {
        private WorkersDataBase workersDataBase;
        private MySQLQueryManager queryManager;
        private MySQLConnectionManager connectionManager;
        public event EventHandler<TrabajadorEvents> NewWorker;

        protected virtual void OnWorkerAdd(TrabajadorEvents e) // agregar workerEvents
        {
            NewWorker?.Invoke(this, e);
        }

        public AgregarTrabajador(MySQLConnectionManager connectionManager)
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

        private int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthDate.Year;
            if (birthDate > now.AddYears(-age))
                age--;
            return age;
        }

        private bool ObtainParentsBool(string parents)
        {
            bool parentsBool; 
            if(parents == "Si")
            {
                parentsBool = true;
            }
            else
            {
                parentsBool = false;
            }

            return parentsBool; 
        }

        private void btn_AddNewWorker_Click(object sender, EventArgs e)
        {
            connectionManager.OpenConnection();

            try
            {
                string name = txb_Name.Text;
                string shor_nomina = txt_nomina.Text;
                string nomina = txt_largeNomina.Text;
                
                DateTime IngressTime = dtime_dateStart.Value;
                DateTime birthDate = dt_birthDay.Value;

                string gender = cbx_Sex.Text;
               
                string rute = txt_route.Text;
                string workArea = txt_WorkArea.Text;
                string education = tb_education.Text;
                string origin = tb_origin.Text;
                string parents = cb_parents.Text;

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(shor_nomina) && !string.IsNullOrEmpty(nomina) && !string.IsNullOrEmpty(gender) && !string.IsNullOrEmpty(rute) && !string.IsNullOrEmpty(workArea) && !string.IsNullOrEmpty(education) && !string.IsNullOrEmpty(origin) && !string.IsNullOrEmpty(parents))
                {

                    int ruteNum = workersDataBase.ObtainID(rute,"decription",  "rutes");
                    int AreaNum = workersDataBase.ObtainID(workArea, "name", "areas");

                    int ageInt = CalculateAge(birthDate);
                    bool parentsBool = ObtainParentsBool(parents);
                    workersDataBase.AddWorkerHumanResources(name,nomina, shor_nomina, IngressTime, birthDate, gender, ruteNum, AreaNum, education, origin, parentsBool, ageInt);
                    // Actualizar la vista de las líneas de producción
                    OnWorkerAdd(new TrabajadorEvents(name,nomina,shor_nomina, IngressTime,birthDate,gender,ruteNum,AreaNum,education, origin, parentsBool,ageInt));

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

            txb_Name.Text = "";
            txt_nomina.Text = "";
            txt_largeNomina.Text = "";
            dtime_dateStart.Text = "";
            cbx_Sex.Text = "";
           dt_birthDay.Text = "";
            txt_route.Text = "";
            txt_WorkArea.Text = "";
            tb_education.Text = "";
            tb_origin.Text = "";
            cb_parents.Text = "";
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

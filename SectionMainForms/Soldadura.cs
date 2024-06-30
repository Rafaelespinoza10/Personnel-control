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
    public partial class Soldadura : Form
    {
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        private WorkersDataBase workerDataBase;

        private string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
        private const string userName = "root";
        private const string databaseName = "registros";
        private const string host = "localhost";

        public Soldadura(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();

            this.connectionManager = connectionManager; // Asignar el connectionManager pasado al constructor

            this.queryManager = QueryManagerProvider.GetQueryManager(connectionManager);
            this.workerDataBase = new WorkersDataBase(queryManager);
        }

        private void NuevoTrabajadorEstampados(object sender, TrabajadorEvents e)
        {
            ListaSoldadura();
        }


        private void ListaSoldadura()
        {
            try
            {
                DataTable dataTable = workerDataBase.GetSoldaduraList();
                if (dataTable != null)
                {
                    dtg_soldadura.DataSource = dataTable; // muestra la lista de estampados. 
                }
                else
                {
                    MessageBox.Show("No se pudieron obtener los datos de los trabajadores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los trabajadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void childForm(Form form)
        {
            foreach (Control control in panelCenterControl.Controls)
            {
                control.Visible = false;
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelCenterControl.Controls.Add(form);
            form.Visible = true;
        }


        // Conexion al panel estampados 

        

        private void connectPanelList1()   //Grupo 1 de soldadura ---> Oswaldo Adranca 
        {
            SoldaduraGrupo1 form = new SoldaduraGrupo1(connectionManager);
            childForm(form);
        }

        private void connectPanelList2()
        {
            SoldaduraGrupo2 form = new SoldaduraGrupo2(connectionManager);
            childForm(form);    
        }

        private void connectPanelList3()
        {
            SoldaduraGrupo3 form = new SoldaduraGrupo3(connectionManager);
            childForm(form);    
        }
        private void ConnectPanelAttendanceGroup1()
        {
            AsistenciaSoldaduraG1 form = new AsistenciaSoldaduraG1(connectionManager);
            childForm(form);
        }
        
        private void ConnectPanelAttendanceGroup2()
        {
            AsistenciaSoldaduraG2 form = new AsistenciaSoldaduraG2(connectionManager);
            childForm(form);
        }

        private void ConnectPanelAttendanceGroup3()
        {
            AsistenciaSoldaduraG3 form = new AsistenciaSoldaduraG3(connectionManager);
            childForm(form);
        }
        private void Soldadura_Load(object sender, EventArgs e)
        {
            ListaSoldadura();
        }

        private void ubicarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTrabajadoresSoldadura altaEstampados = new AltaTrabajadoresSoldadura(connectionManager);
            altaEstampados.NewWorkerSoldadura += NuevoTrabajadorEstampados;
            altaEstampados.Show();
        }

        private void marcosNarcisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectPanelList1();
        }

        private void oscarArmendarizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectPanelList2();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            connectPanelList3();
        }

        private void tomarAsistenciaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConnectPanelAttendanceGroup1();
        }

        private void tomarAsistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConnectPanelAttendanceGroup2();
        }

        private void tomarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectPanelAttendanceGroup3();
        }
    }
}

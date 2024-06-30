using PEASA_App.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace PEASA_App
{
    public partial class Estampados : Form
    {
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        private WorkersDataBase workerDataBase;


        public Estampados(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = QueryManagerProvider.GetQueryManager(connectionManager);
            this.workerDataBase = new WorkersDataBase(queryManager);
        }

        private void NuevoTrabajadorEstampados(object sender, TrabajadorEvents e)
        {
            ListaEstampados();
        }

        private void Estampados_Load(object sender, EventArgs e)
        {
            ListaEstampados();
        }

        private void ListaEstampados()
        {
            try
            {
                DataTable dataTable = workerDataBase.GetEstampadosList();
                if (dataTable != null)
                {
                    dtg_estampados.DataSource = dataTable;
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
            foreach (Control control in panelControlCenter.Controls)
            {
                control.Visible = false;
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelControlCenter.Controls.Add(form);
            form.Visible = true;
        }

        private void connectPanelList1()
        {
            EstampadosGrupo1 form = new EstampadosGrupo1(connectionManager);
            childForm(form);
        }

        private void connectPanelList2()
        {
            EstampadosGrupo2 form = new EstampadosGrupo2(connectionManager);
            childForm(form);
        }

        private void ConnectPanelGetAttendanceGroup1()
        {
            AsistenciaEstampados form = new AsistenciaEstampados(connectionManager);
            childForm(form);
        }

        private void ConnectPanelGetAttendanceGroup2()
        {
            AsistenciaEstampados2 form = new AsistenciaEstampados2(connectionManager);
            childForm(form);
        }

        private void ubicarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTrabajadorEstampados altaEstampados = new AltaTrabajadorEstampados(connectionManager);
            altaEstampados.NewWorkerEstampados += NuevoTrabajadorEstampados;
            altaEstampados.Show();
        }

        private void marcosNarcisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectPanelList1();
        }

        private void tomarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectPanelGetAttendanceGroup1();
        }

        private void oscarArmendarizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectPanelList2();
        }

        private void tomarListaDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectPanelGetAttendanceGroup2();
        }
    }
}

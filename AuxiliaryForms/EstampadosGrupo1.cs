using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public partial class EstampadosGrupo1 : Form
    {
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        private AttandanceDataBase attandanceDataBase;
        private WorkersDataBase workersDataBase;
        public EstampadosGrupo1(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = QueryManagerProvider.GetQueryManager(connectionManager);
            this.attandanceDataBase = new AttandanceDataBase(queryManager);
            this.workersDataBase = new WorkersDataBase(queryManager);
        }
        
        private void ActualizarListaAsistencia()
        {
            try
            {
                DataTable dataTable = workersDataBase.GetAttandanceEstampadosList();
                if (dataTable != null)
                {
                    dtgv_jobcenter.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la lista de asistencia de los trabajadores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de asistencia de los trabajadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void EstampadosGrupo1_Load_1(object sender, EventArgs e)
        {
            ActualizarListaAsistencia();

        }
    }
}

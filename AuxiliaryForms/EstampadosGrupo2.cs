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
    public partial class EstampadosGrupo2 : Form
    {
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        private AttandanceDataBase attandanceDataBase;
        private WorkersDataBase workersDataBase;

        public EstampadosGrupo2(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = QueryManagerProvider.GetQueryManager(connectionManager);
            this.attandanceDataBase = new AttandanceDataBase(queryManager);
            this.workersDataBase = new WorkersDataBase(queryManager);
        }

        private void EstampadosGrupo2_Load(object sender, EventArgs e)
        {
            VerListaTrabajadores();
        }

        private void VerListaTrabajadores()
        {
            try
            {
                DataTable dataTable = workersDataBase.GetAttandanceEstampadosList2();
                if (dataTable != null)
                {
                    dtgv_jobcenter.DataSource = dataTable;
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
    }
}

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
    public partial class TiempoExtra : Form
    {

        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        private ExtraTimeDataBase extraTimeDataBase;
        public TiempoExtra(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = QueryManagerProvider.GetQueryManager(connectionManager);
            this.extraTimeDataBase = new ExtraTimeDataBase(queryManager);
        }

        private void TiempoExtra_Load(object sender, EventArgs e)
        {
          //  ListaTiempoExtra();
        }
        /*
        private void ListaTiempoExtra()
        {
            try
            {
               // DataTable dataTable = extraTimeDataBase.GetExtraTimeTable();

                if(dataTable != null)
                {
                    dtg_extraTime.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la tabla del tiempo extra", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Error al cargar a los trabajadores {ex.Message}");
            }
        }
        */

        private void AgregaTiempoExtra(object sender, ExtraTimeEvents e)
        {
            //ListaTiempoExtra();
        }

        private void agregarTiempoExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTiempoExtra agregarTiempoExtra = new AgregarTiempoExtra(connectionManager);
           // agregarTiempoExtra.NewExtraTime += AgregaTiempoExtra;
            agregarTiempoExtra.Show();
        }
    }
}

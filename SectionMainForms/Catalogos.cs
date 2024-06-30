using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PEASA_App
{
    public partial class Catalogos : Form
    {
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        
        private string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
        private const string userName = "root";
        private const string databaseName = "registros";
        private const string host = "localhost";


        public Catalogos(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
     
            this.connectionManager = connectionManager;       
            this.queryManager = new MySQLQueryManager(connectionManager.GetConnection());
        
        }


        private void childForm(object childform)
         {
             if (this.panelCenterControl.Controls.Count > 0)
             {
                 this.panelCenterControl.Controls.RemoveAt(0);
             }
             Form cf = childform as Form;
             cf.TopLevel = false;
             cf.Dock = DockStyle.Fill;
             this.panelCenterControl.Controls.Add(cf);
             this.panelCenterControl.Tag = cf;
             cf.Show();
         }

        // Conexion al panel de catalogo de centros de trabajo 
       
        private void ConnectPanel<T>(Func<MySQLConnectionManager, T> formConstructor) where T : Form
        {
            try
            {
                using (MySQLConnectionManager connectionManager = new MySQLConnectionManager(host, databaseName, userName, password))
                {
                    connectionManager.OpenConnection();

                    childForm(formConstructor(connectionManager));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar establecer la conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connectPanelJobCenter()
        {
            ConnectPanel((connectionManager) => new CentroTrabajo(connectionManager));
        }

        private void ConnectPaneltransportRoute()
        {
            ConnectPanel((connectionManager) => new RutasTransporte(connectionManager));
        }

        private void ConnectPanelProductionLine()
        {
            ConnectPanel((connectionManager) => new LineaProduccion(connectionManager));
        }

        private void connectPanelJobArea()
        {
            ConnectPanel((connectionManager) => new AreaTrabajo(connectionManager));
        }

        private void connectPanelWorkers()
        {
           ConnectPanel((connectionManager) => new Trabajadores(connectionManager));
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectPanelProductionLine();

        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            connectPanelJobCenter();
        }

        private void abrirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConnectPaneltransportRoute();
        }
        private void abrirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            connectPanelJobArea();
        }

        private void abrirToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            connectPanelWorkers();
        
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is LineaProduccion)
                {
                    form.Close();
                    break; 
                }
            }
        }

    }
}

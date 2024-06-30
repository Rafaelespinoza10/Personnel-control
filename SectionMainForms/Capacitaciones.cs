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

    public partial class Capacitaciones : Form
    {
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        private CapacitationDataBase capacitationDataBase;
        
        public Capacitaciones(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = QueryManagerProvider.GetQueryManager(connectionManager);
            this.capacitationDataBase = new CapacitationDataBase(queryManager);

        }

        private void Capacitaciones_Load(object sender, EventArgs e)
        {
            ListaCapacitaciones();
        }
        private void ListaCapacitaciones()
        {
            try
            {
                DataTable dataTable = capacitationDataBase.GetCapacitationTable();
                if (dataTable != null)
                {
                   dgv_CapacitationTable.DataSource = dataTable;
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


        private void AgregarCapacitacion(object sender, CapacitationEvents e)
        {
            ListaCapacitaciones();
        }
        private void agregarCapacitaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregaCapacitacion agregarCapacitacion = new AgregaCapacitacion(connectionManager);
            agregarCapacitacion.NewCapacitation += AgregarCapacitacion; // Suscripción al evento
            agregarCapacitacion.Show();
        }

    }
}

using MySqlX.XDevAPI.Common;
using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public partial class CentroTrabajo : Form
    {
        private JobCenterDataBase jobCenterDataBase;
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;

        

        
        public CentroTrabajo(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager; // Asignar el connectionManager pasado al constructor

            this.queryManager = QueryManagerProvider.GetQueryManager(connectionManager);
            this.jobCenterDataBase = new JobCenterDataBase(queryManager);
            
            AgregarCentroTrabajo agregarCentro = new AgregarCentroTrabajo(connectionManager);

        }

        private void ActualizarTablaCentrosTrabajo()
        {
            try
            {
                DataTable dataTable = jobCenterDataBase.GetJobCenterTable();
                if (dataTable != null)
                {
                    dtgv_jobcenter.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No se pudieron obtener los datos de los centros de trabajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los centros de trabajo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void AgregarNuevoCentroTrabajo(object sender, CentroTrabajoEvents e)
        {
            ActualizarTablaCentrosTrabajo();
        }


        private void CentroTrabajo_Load(object sender, EventArgs e)
        {
            ActualizarTablaCentrosTrabajo();
        }

       
        

        private void btn_AddJobCenter_Click(object sender, EventArgs e)
        {
            AgregarCentroTrabajo agregaCentro = new AgregarCentroTrabajo(connectionManager);
            agregaCentro.NewJobCenter += AgregarNuevoCentroTrabajo;
            agregaCentro.Show();
        }

        private void btn_deleteJobCenter_Click(object sender, EventArgs e)
        {
            try
            {
                string nameJobCenter =Txt_NumeroCentro.Text;
                jobCenterDataBase.DeleteJobCenter(nameJobCenter);

                DataTable dataTable = jobCenterDataBase.GetJobCenterTable();
                if (dataTable != null)
                {
                    dtgv_jobcenter.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese agregue una nuevo centro de trabajo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception er)
            {

            }
            Txt_NumeroCentro.Text = "";
        }

        private void btn_searchJobCenter_Click(object sender, EventArgs e)
        {
            try
            {
                string nameLine = Txt_NumeroCentro.Text;
                DataTable searchResult = jobCenterDataBase.SearchCenterNumber(nameLine);

                if (searchResult != null)
                {
                   dtgv_jobcenter.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception er)
            {
                MessageBox.Show($"Error al buscar el centro de trabajo: {er.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Txt_NumeroCentro.Text = "";
        }
    }
}


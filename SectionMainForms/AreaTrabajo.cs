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
    public partial class AreaTrabajo : Form
    {
        private JobAreaDataBase jobAreaDataBase;
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;

        public AreaTrabajo(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;

            this.queryManager = QueryManagerProvider.GetQueryManager(connectionManager);
            this.jobAreaDataBase= new JobAreaDataBase(queryManager);

          
        }

        private void btn_addjobarea_Click(object sender, EventArgs e)
        {

            AgregarAreaTrabajo agregaArea = new AgregarAreaTrabajo(connectionManager);
            agregaArea.NewAreaJob += AgregarNuevaArea;
            agregaArea.Show();
        }

        private void AgregarNuevaArea(object sender, AreaTrabajoEvents e)
        {
            ActualizarTablaAreaTrabajo();
        }

        private void ActualizarTablaAreaTrabajo()
        {
            try
            {
                DataTable dataTable = jobAreaDataBase.GetAreaJobTable();
                if (dataTable != null)
                {
                    dtgv_jobcenter.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No se pudieron obtener los datos de área de trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el area de trabajo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        
        private void AreaTrabajo_Load(object sender, EventArgs e)
        {
            ActualizarTablaAreaTrabajo();
        }

        private void btn_searchJobCenter_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nameLine = Txt_NumeroCentro.Text;
                DataTable searchResult = jobAreaDataBase.SearchAreaJob(nameLine);

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
                MessageBox.Show($"Error al buscar el área de trabajo: {er.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Txt_NumeroCentro.Text = "";
        }

        private void btn_deleteJobCenter_Click(object sender, EventArgs e)
        {
            try
            {
                string nameRute = Txt_NumeroCentro.Text;
                jobAreaDataBase.DeleteJobCenter(nameRute);

                DataTable dataTable = jobAreaDataBase.GetAreaJobTable();
                if (dataTable != null)
                {
                    dtgv_jobcenter.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese agregue una nueva área de trabajo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception er)
            {

            }
            Txt_NumeroCentro.Text = "";


        }
    }
}

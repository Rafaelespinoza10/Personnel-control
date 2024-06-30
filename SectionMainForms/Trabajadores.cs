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
    public partial class Trabajadores : Form
    {
        private WorkersDataBase workersDataBase;
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        private SearchWorkerFilter workerFilter;
        public Trabajadores(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager; // Asignar el connectionManager pasado al constructor

            this.queryManager = QueryManagerProvider.GetQueryManager(connectionManager);
            this.workersDataBase = new WorkersDataBase(queryManager);
            this.workerFilter = new SearchWorkerFilter(queryManager);

            //Suscribirse al evento de agregar linea
            AgregarTrabajador agregarTrabajador = new AgregarTrabajador(connectionManager);

        }

        
        private void AgregarNuevoTrabajador(object sender, TrabajadorEvents e)
        {
            ActualizarTablaTrabajadores();
        }
        private void Trabajadores_Load(object sender, EventArgs e)
        {
            ActualizarTablaTrabajadores();

        }
    


        private void ActualizarTablaTrabajadores()
        {
            try
            {
                DataTable dataTable = workersDataBase.GetWorkersData();
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
        /*
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string nameLine = txt_nameLineProduction.Text;
                DataTable searchResult = productionLineDataBase.SearchLineProduction(nameLine);

                if (searchResult != null)
                {
                    dataProductionLine.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception er)
            {
                MessageBox.Show($"Error al buscar la línea de producción: {er.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_nameLineProduction.Text = "";
        }



        private void btn_DeleteProductionLine_Click(object sender, EventArgs e)
        {
            try
            {
                string nameLine = txt_nameLineProduction.Text;
                productionLineDataBase.DeleteLineProduction(nameLine);

                DataTable dataTable = productionLineDataBase.GetDataProductionLine();
                if (dataTable != null)
                {
                    dataProductionLine.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese agregue una nueva linea de producción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception er)
            {

            }
            txt_nameLineProduction.Text = "";
        }
        */


        private void btn_addjobarea_Click(object sender, EventArgs e)
        {
            AgregarTrabajador agregarTrabajador = new AgregarTrabajador(connectionManager);
            agregarTrabajador.NewWorker += AgregarNuevoTrabajador; // Suscripción al evento
            agregarTrabajador.Show();
        }

        private void agregarNuevoTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTrabajador agregarTrabajador = new AgregarTrabajador(connectionManager);
            agregarTrabajador.NewWorker += AgregarNuevoTrabajador; // Suscripción al evento
            agregarTrabajador.Show();
        }

        private void darDeAltaIncapacidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Incapacidades incapacidades = new Incapacidades(connectionManager);
            incapacidades.NewIncapacity += AgregarNuevoTrabajador;
            incapacidades.Show();
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bajas bajas = new Bajas(connectionManager);
            bajas.NewLeave += AgregarNuevoTrabajador;
            bajas.Show();
        }



        private void btn_searchNomina_Click(object sender, EventArgs e)
        {
            string short_nomina = txt_nomina.Text;
            string name = txt_Name.Text;
            try
            {
                DataTable result = workerFilter.SearchWorker(short_nomina, name );
                if (result != null && result.Rows.Count > 0)
                {
                    dtgv_jobcenter.DataSource = result;
                }
                else
                {
                    ActualizarTablaTrabajadores();
                    MessageBox.Show("No se encontraron trabajadores con esa nómina o nombre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_searchName_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            try
            {
                DataTable result = workerFilter.SearchWorker("", name); // Pasamos "" para short_nomina
                if (result != null && result.Rows.Count > 0)
                {
                    dtgv_jobcenter.DataSource = result;
                }
                else
                {
                    ActualizarTablaTrabajadores();
                    MessageBox.Show("No se encontraron trabajadores con ese nombre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

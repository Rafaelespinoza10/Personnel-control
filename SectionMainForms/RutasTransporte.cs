
using MySql.Data.MySqlClient;
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
    public partial class RutasTransporte: Form
    {
        private TransportRutesDataBase transportRutesDataBase;
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;

        public RutasTransporte(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;

            this.queryManager = QueryManagerProvider.GetQueryManager(connectionManager);
            this.transportRutesDataBase = new TransportRutesDataBase(queryManager);

            AgregarRutasTransporte agregarRuta = new AgregarRutasTransporte(connectionManager);

        }
      
        private void btn_AddRute_Click(object sender, EventArgs e)
        {
            AgregarRutasTransporte agregaRuta = new AgregarRutasTransporte(connectionManager);
            agregaRuta.RutaTransporteAgregada += AgregarNuevaRutaTransporte;
            agregaRuta.Show();
        }

        private void AgregarNuevaRutaTransporte(object sender, RutasTransporteEvents e)
        {
            ActualizarTablaRutasTransporte();
        }

        private void ActualizarTablaRutasTransporte()
        {
            try
            {
                DataTable dataTable = transportRutesDataBase.GetDataTransportRute();
                if (dataTable != null)
                {
                    dtGridRutes.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No se pudieron obtener los datos de las líneas de producción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las líneas de producción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RutasTransporte_Load(object sender, EventArgs e)
        {
            ActualizarTablaRutasTransporte();
        }

        private void btn_deleteJobCenter_Click(object sender, EventArgs e)
        {
            try
            {
                string nameRute = txtTransportDescription.Text;
                transportRutesDataBase.DeleteTransportRute(nameRute);

                DataTable dataTable = transportRutesDataBase.GetDataTransportRute();
                if (dataTable != null)
                {
                    dtGridRutes.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese agregue una nueva linea de producción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception er)
            {

            }
            txtTransportDescription.Text = "";
        }

        private void btn_searchJobCenter_Click(object sender, EventArgs e)
        {
            try
            {
                string nameLine = txtTransportDescription.Text;
                DataTable searchResult = transportRutesDataBase.SearchTransportRute(nameLine);

                if (searchResult != null)
                {
                   dtGridRutes.DataSource = searchResult;
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
            txtTransportDescription.Text = "";
        }
    }
}

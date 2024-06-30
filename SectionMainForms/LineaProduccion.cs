using MySql.Data.MySqlClient;
using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PEASA_App
{
    public partial class LineaProduccion : Form
    {
        private ProductionLineDataBase productionLineDataBase;
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        
        public LineaProduccion(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager; // Asignar el connectionManager pasado al constructor

            this.queryManager = QueryManagerProvider.GetQueryManager(connectionManager);
            this.productionLineDataBase = new ProductionLineDataBase(queryManager);

            //Suscribirse al evento de agregar linea
            AgregarLineaProduccion agregarLineaForm = new AgregarLineaProduccion(connectionManager);
           
        }

        private void AgregarNuevaLineaProduccion(object sender, LineaProduccionEvents e)
        {
            ActualizarTablaProduccion();
        }
        private void LineaProduccion_Load(object sender, EventArgs e)
        {
            ActualizarTablaProduccion();
        }

    

        private void ActualizarTablaProduccion()
        {
            try
            {
                DataTable dataTable = productionLineDataBase.GetDataProductionLine();
                if (dataTable != null)
                {
                    dataProductionLine.DataSource = dataTable;
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
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podidio borrar la lunea de produccion. " + $"{ ex}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            txt_nameLineProduction.Text = "";
        }

        private void btn_AddProductionline_Click(object sender, EventArgs e)
        {
            AgregarLineaProduccion agregaLinea = new AgregarLineaProduccion(connectionManager);
            agregaLinea.LineaProduccionAgregada += AgregarNuevaLineaProduccion; // Suscripción al evento
            agregaLinea.Show();
        }
    }
}
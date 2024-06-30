using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public partial class AgregarLineaProduccion : Form
    {
        private ProductionLineDataBase productionLineDataBase;
        private MySQLConnectionManager connectionManager;

        public event EventHandler<LineaProduccionEvents> LineaProduccionAgregada;

        protected virtual void OnLineaProduccionAgregada(LineaProduccionEvents e)
        {
            LineaProduccionAgregada ?.Invoke(this, e);
           
        }


        public AgregarLineaProduccion(MySQLConnectionManager connectionManager)
        {

            InitializeComponent();
            this.connectionManager = connectionManager;
            MySQLQueryManager queryManager = new MySQLQueryManager(connectionManager.GetConnection());
            this.productionLineDataBase = new ProductionLineDataBase(queryManager);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void btn_addNewLine_Click(object sender, EventArgs e)
        {
            connectionManager.OpenConnection();
            
            try
            {
                string nombreLinea = txt_lineProductionAdd.Text;
                if (!string.IsNullOrEmpty(nombreLinea))
                {
                    productionLineDataBase.AddLineProduction(nombreLinea);

                    // Actualizar la vista de las líneas de producción
                    OnLineaProduccionAgregada(new LineaProduccionEvents(nombreLinea));

                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre para la nueva línea de producción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la línea de producción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt_lineProductionAdd.Text = "";
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

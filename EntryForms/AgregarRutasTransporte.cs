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
    public partial class AgregarRutasTransporte : Form
    {


        private TransportRutesDataBase  transportRutesDataBase;
       private MySQLQueryManager queryManager;
       private MySQLConnectionManager connectionManager;

        public event EventHandler<RutasTransporteEvents> RutaTransporteAgregada;

        protected virtual void OnRutaTransporteAgregada(RutasTransporteEvents e)
        {
            RutaTransporteAgregada?.Invoke(this, e);

        }

        public AgregarRutasTransporte(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = new MySQLQueryManager(connectionManager.GetConnection()); // Inicializar
            this.transportRutesDataBase = new TransportRutesDataBase(queryManager);

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

 
        private void btn_addNewRute_Click(object sender, EventArgs e)
        {
            connectionManager.OpenConnection();
            try
            {
                string ruteNumber = txt_RuteNumber.Text;
                string description = txt_descriptionRute.Text;

                int number = Convert.ToInt32(ruteNumber);

                if (!string.IsNullOrEmpty(ruteNumber) && !string.IsNullOrEmpty(description))
                {
                    transportRutesDataBase.AddRow(number, description);

                    // Actualizar la vista de las rutas de transporte
                    OnRutaTransporteAgregada(new RutasTransporteEvents(number, description));

                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre para la nueva ruta de transporte", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la ruta de transporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt_RuteNumber.Text = "";
            txt_descriptionRute.Text = "";
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panelTitle_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

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
    public partial class UserInfo : Form
    {
        private MySQLConnectionManager connectionManager;
        private MySQLQueryManager queryManager;
        private const string table_name = "Workers";

        public UserInfo(MySQLConnectionManager connectionManager)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.queryManager = new MySQLQueryManager(connectionManager.GetConnection());

        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM {table_name}";
            dataGridView1.DataSource = ExecuteSelectQuery(query);
        }

        private DataTable ExecuteSelectQuery(string query)
        {
            try
            {
            DataTable dataTable = queryManager.ExecuteSelectQuery(query);
            return dataTable;
            }catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}

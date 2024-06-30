using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEASA_App
{
    internal class ExtraTimeDataBase
    {

        private const string col1 = "date";
        private const string col2 = "area_id";
        private const string col3 = "turn";
        private const string col4 = "machine_id";
        private const string col5 = "hours";
        private const string col6 = "worker_id";
        private const string col7 = "part_number_id";
        private const string col8 = "reason";
        private const string col9 = "gerent_id";
        private const string col10 = "route_id";
        private const string col11 = "cost_for_routes";

        private MySQLQueryManager queryManager;


        internal ExtraTimeDataBase(MySQLQueryManager queryManager)
        {
            this.queryManager = queryManager;
        }

        /*
        public DataTable GetExtraTimeTable()
        {
            string query = $"SELECT w.short_nomina As Nomina,  "
        }
        */

    }
}

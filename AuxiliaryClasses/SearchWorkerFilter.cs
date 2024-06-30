using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PEASA_App
{
    internal class SearchWorkerFilter
    {
        private MySQLQueryManager queryManager;
        private readonly WorkersDataBase workersDataBase;

        internal SearchWorkerFilter(MySQLQueryManager queryManager)
        {
            this.queryManager = queryManager;
            this.workersDataBase = new WorkersDataBase(queryManager);

        }

        public DataTable SearchWorker(string short_nomina, string name)
        {
            return workersDataBase.SearchWorkers(short_nomina, name);
        }

     



    }
}

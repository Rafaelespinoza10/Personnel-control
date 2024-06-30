using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEASA_App
{
    public static class QueryManagerProvider
    {
        private static MySQLQueryManager queryManager;

        internal static MySQLQueryManager GetQueryManager(MySQLConnectionManager connectionManager)
        {
            if (queryManager == null)
            {
                queryManager = new MySQLQueryManager(connectionManager.GetConnection());
            }
            return queryManager;
        }
    }
}

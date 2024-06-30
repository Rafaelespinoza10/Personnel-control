using PEASA_App.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public class AttandanceEvents
    {
        public DateTime date { get; }
        public int id_worker { get; }
        public string status { get; }

        public AttandanceEvents( int id_worker,DateTime date,  string status)
        {
            this.date = date;
            this.id_worker = id_worker;
            this.status = status;
        }
    }
}


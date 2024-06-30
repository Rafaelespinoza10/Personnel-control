using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public class CentroTrabajoEvents
    {
        public string centerNumber { get; }
        public string description { get; }
        public int productionLine { get; }
        public int requieredPersonnel {  get; } 
        public int activePersonnel { get; }

        public CentroTrabajoEvents(string centerNumber, string description, int productionLine, int requieredPersonnel, int activePersonnel)
        {
            this.centerNumber = centerNumber;
            this.description = description;
            this.productionLine = productionLine;
            this.requieredPersonnel = requieredPersonnel;
            this.activePersonnel = activePersonnel;
        }
    }
}

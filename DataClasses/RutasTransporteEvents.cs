using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEASA_App
{
    public class RutasTransporteEvents
    {
       public int NumberRoute { get; }
        public string DescriptionRoute { get; }

        public RutasTransporteEvents(int numberRoute, string descriptionRoute)
        {
            NumberRoute = numberRoute;
            DescriptionRoute = descriptionRoute;
        }
    }
}
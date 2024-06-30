using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEASA_App
{
    public class TrabajadorEvents
    {
        public string name { get; }
        public string nomina { get; }
        public string short_nomina { get; }
        public DateTime join_date { get; }
        public DateTime date_of_birth { get; }
        
        public int shift { get; set;  }
        public int category { get; set; }
        public int id_machine { get; }
        public int id_gerent { get; }
        public int rute_Num { get; }
        public string education { get; }
        public string gender { get; }
        public double weight {  get; }
        public double height {  get; }  
        public string origin {  get; }

        public bool parent { get; }
        public int active { get; }
        public bool incapacitated { get; }
        public int area_id { get; }
        public int ageNum { get; }
        public string senority { get; } // antiguedad.
        public string exit_reason { get; }
        public DateTime exit_date { get; }

        public bool leave_worker { get;  }


        public TrabajadorEvents(string name, string nomina, string shor_nomina, DateTime join_date, DateTime birthDate,  string gender, int id_rute, int id_area, string education, string origin, bool parent, int age)
        {
            this.name = name;
            this.nomina = nomina;
            this.short_nomina = shor_nomina; 
            this.join_date = join_date;
            this.date_of_birth = birthDate;
            this.gender = gender;
            this.rute_Num = id_rute;
            this.area_id= id_area;
            this.education = education;
            this.origin = origin;
            this.parent = parent;
            this.ageNum = age;
        }
        public TrabajadorEvents(string nomina, int active, bool incapacitated)
        {
            this.nomina = nomina;
            this.active = active; 
            this.incapacitated = incapacitated;
        }

        public TrabajadorEvents(string nomina, bool leave_worker,int active,  bool incapacitated, string exit_reason, DateTime exit_date)
        {
            this.nomina = nomina;
            this.leave_worker = leave_worker;
            this.active = active;
            this.incapacitated = incapacitated;
            this.exit_reason = exit_reason;
            this.exit_date = exit_date;
        }

        public TrabajadorEvents(string nomina, int id_machine, int id_gerent)
        {
            this.nomina = nomina;
            this.id_machine = id_machine;
            this.id_gerent = id_gerent;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PEASA_App
{

    public class CapacitationEvents
    {

        public int id_worker { get; }

        public bool safety_training { get; }
        public int safety_training_score { get; }
        public DateTime safety_training_date { get; }

        public bool turning_training { get; }
        public int turning_training_score { get; }  
        public DateTime turning_training_date { get; }  

        public bool production_report {  get; } 
        public int production_report_score { get; } 
        public DateTime production_report_date { get; } 

        public bool operation_conditions_training { get; }
        public int operation_conditions_training_score { get;}
        public DateTime operation_conditions_training_date { get;}

        public bool use_of_stilt_training { get; }
        public int use_of_stilt_score { get; }
        public DateTime use_of_still_date { get;}

        public bool self_maintenace_checklist_training { get; }
        public int self_maintenace_checklist_score {  get; }
        public DateTime self_maintenace_checklist_date { get; }

        public bool measurement_instruments_training { get; }
        public int measurement_instruments_training_score { get; }  
        public DateTime measurement_instruments_training_date { get; }


        public bool non_conforming_product_control_training { get; }
        public int non_conforming_product_score { get; }
        public DateTime non_conforming_product_date { get; }


        public bool inspection_sheet_training { get; }
        public int inspection_sheet_score { get; }
        public DateTime inspection_sheet_date { get;  }
    
    
        public CapacitationEvents(int id_worker, bool safety_training, int safety_training_score, DateTime safety_training_date, bool turning_training, int turning_training_score, DateTime turning_training_date, bool production_report, int production_report_score, DateTime production_report_date, bool operation_conditions_training, int operation_conditions_training_score, DateTime operation_conditions_training_date, bool use_of_stilt_training, int use_of_stilt_score, DateTime use_of_still_date, bool self_maintenace_checklist_training, int self_maintenace_checklist_score, DateTime self_maintenace_checklist_date, bool measurement_instruments_training, int measurement_instruments_training_score, DateTime measurement_instruments_training_date, bool non_conforming_product_control_training, int non_conforming_product_score, DateTime non_conforming_product_date, bool inspection_sheet_training, int inspection_sheet_score, DateTime inspection_sheet_date)
        {
            this.id_worker = id_worker;
            this.safety_training = safety_training;
            this.safety_training_score = safety_training_score;
            this.safety_training_date = safety_training_date;
            this.turning_training = turning_training;
            this.turning_training_score = turning_training_score;
            this.turning_training_date = turning_training_date;
            this.production_report = production_report;
            this.production_report_score = production_report_score;
            this.production_report_date = production_report_date;
            this.operation_conditions_training = operation_conditions_training;
            this.operation_conditions_training_score = operation_conditions_training_score;
            this.operation_conditions_training_date = operation_conditions_training_date;
            this.use_of_stilt_training = use_of_stilt_training;
            this.use_of_stilt_score = use_of_stilt_score;
            this.use_of_still_date = use_of_still_date;
            this.self_maintenace_checklist_training = self_maintenace_checklist_training;
            this.self_maintenace_checklist_score = self_maintenace_checklist_score;
            this.self_maintenace_checklist_date = self_maintenace_checklist_date;
            this.measurement_instruments_training = measurement_instruments_training;
            this.measurement_instruments_training_score = measurement_instruments_training_score;
            this.measurement_instruments_training_date = measurement_instruments_training_date;
            this.non_conforming_product_control_training = non_conforming_product_control_training;
            this.non_conforming_product_score = non_conforming_product_score;
            this.non_conforming_product_date = non_conforming_product_date;
            this.inspection_sheet_training = inspection_sheet_training;
            this.inspection_sheet_score = inspection_sheet_score;
            this.inspection_sheet_date = inspection_sheet_date;
        }
        
        public CapacitationEvents(int id_worker, bool safety_training, int safety_training_score, DateTime safety_training_data) {
        
            this.id_worker = id_worker;
            this.safety_training = safety_training;
            this.safety_training_score = safety_training_score;
            this.safety_training_date = safety_training_data;
        
        }



    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEASA_App

{

    internal class ExtraTimeEvents
    {

        public DateTime date {  get; }
        public int area_id { get; }
        public int turn {  get; }
        public int machine_id { get; }
        public int hours {  get; }
        public int worker_id { get; }
        public int part_number_id { get; }
        public int gerent_id { get; }
        public int route_id {  get; }
        public int cost_for_routes { get; set; }

        public ExtraTimeEvents(DateTime date, int area_id, int turn, int machine_id, int hours, int worker_id, int part_number_id, int gerent_id, int route_id, int cost_for_routes)
        {
            this.date = date;
            this.area_id = area_id;
            this.turn = turn;
            this.machine_id = machine_id;
            this.hours = hours;
            this.worker_id = worker_id;
            this.part_number_id = part_number_id;
            this.gerent_id = gerent_id;
            this.route_id = route_id;
            this.cost_for_routes = cost_for_routes;
        }
    }
}

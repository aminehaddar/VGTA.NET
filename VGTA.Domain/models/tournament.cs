using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class tournament
    {
        public tournament()
        {
            this.participants = new List<participant>();
        }

        public int id { get; set; }
        public Nullable<System.DateTime> created_after { get; set; }
        public Nullable<System.DateTime> created_before { get; set; }
        public string description { get; set; }
        public bool hold_third_place_match { get; set; }
        public string name { get; set; }
        public bool show_rounds { get; set; }
        public int signup_cap { get; set; }
        public Nullable<System.DateTime> start_at { get; set; }
        public string state { get; set; }
        public string subdomain { get; set; }
        public string tournament_type { get; set; }
        public string url { get; set; }
        public Nullable<int> id_event { get; set; }
        public virtual @Event @event { get; set; }
        public virtual ICollection<participant> participants { get; set; }
    }
}

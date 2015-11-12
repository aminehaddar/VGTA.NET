using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class participant
    {
        public int id { get; set; }
        public bool checked_in { get; set; }
        public Nullable<System.DateTime> checked_in_at { get; set; }
        public string name { get; set; }
        public Nullable<int> tournament_id { get; set; }
        public virtual tournament tournament { get; set; }
    }
}

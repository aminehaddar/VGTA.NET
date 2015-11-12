using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class Event
    {
        public @Event()
        {
            this.contributions = new List<contribution>();
            this.tournaments = new List<tournament>();
            this.trophies = new List<trophy>();
        }

        public int id_event { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string name { get; set; }
        public int nbrReservation { get; set; }
        public string streaming { get; set; }
        public Nullable<int> teamOrganisation { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<int> venue { get; set; }
        public virtual ICollection<contribution> contributions { get; set; }
        public virtual ICollection<tournament> tournaments { get; set; }
        public virtual ICollection<trophy> trophies { get; set; }
        public virtual team team { get; set; }
        public virtual venue venue1 { get; set; }
        public virtual typeevent typeevent { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class venue
    {
        public venue()
        {
            this.events = new List<@Event>();
        }

        public int id_venue { get; set; }
        public string adress { get; set; }
        public string city { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public virtual ICollection<@Event> events { get; set; }
    }
}

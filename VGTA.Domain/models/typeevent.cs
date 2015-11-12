using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class typeevent
    {
        public typeevent()
        {
            this.events = new List<@Event>();
        }

        public int id_type { get; set; }
        public string type_event { get; set; }
        public virtual ICollection<@Event> events { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class vote
    {
        public vote()
        {
            this.elections = new List<election>();
        }

        public int id { get; set; }
        public Nullable<System.DateTime> date_Fin { get; set; }
        public Nullable<System.DateTime> date_debut { get; set; }
        public int nbRequiredAdmin { get; set; }
        public virtual ICollection<election> elections { get; set; }
    }
}

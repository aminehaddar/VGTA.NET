using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class brand
    {
        public brand()
        {
            this.equipments = new List<equipment>();
        }

        public int id { get; set; }
        public string brand1 { get; set; }
        public virtual ICollection<equipment> equipments { get; set; }
    }
}

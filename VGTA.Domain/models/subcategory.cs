using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class subcategory
    {
        public subcategory()
        {
            this.topics = new List<topic>();
        }

        public int id_subcategory { get; set; }
        public string title { get; set; }
        public Nullable<int> id_category { get; set; }
        public virtual category category { get; set; }
        public virtual ICollection<topic> topics { get; set; }
    }
}

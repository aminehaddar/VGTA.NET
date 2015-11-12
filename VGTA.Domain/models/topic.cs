using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class topic
    {
        public topic()
        {
            this.messages = new List<message>();
        }

        public int id_topic { get; set; }
        public Nullable<System.DateTime> post_time { get; set; }
        public string title { get; set; }
        public Nullable<int> id_gamer { get; set; }
        public Nullable<int> id_subcategory { get; set; }
        public virtual gamer gamer { get; set; }
        public virtual ICollection<message> messages { get; set; }
        public virtual subcategory subcategory { get; set; }
    }
}

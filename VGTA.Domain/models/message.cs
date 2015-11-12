using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class message
    {
        public int id_msg { get; set; }
        public string message1 { get; set; }
        public Nullable<System.DateTime> post_time { get; set; }
        public string title { get; set; }
        public Nullable<int> id_gamer { get; set; }
        public Nullable<int> id_topic { get; set; }
        public virtual gamer gamer { get; set; }
        public virtual topic topic { get; set; }
    }
}

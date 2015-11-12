using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class gamer
    {
        public gamer()
        {
            this.elections = new List<election>();
            this.trophies = new List<trophy>();
            this.messages = new List<message>();
            this.topics = new List<topic>();
        }

        public int id { get; set; }
        public bool accepted { get; set; }
        public Nullable<int> age { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public bool hasVoted { get; set; }
        public byte[] image { get; set; }
        public string lastName { get; set; }
        public int numtel { get; set; }
        public string pwd { get; set; }
        public int rank { get; set; }
        public int record { get; set; }
        public Nullable<int> role { get; set; }
        public Nullable<int> team { get; set; }
        public virtual ICollection<election> elections { get; set; }
        public virtual team team1 { get; set; }
        public virtual ICollection<trophy> trophies { get; set; }
        public virtual ICollection<message> messages { get; set; }
        public virtual ICollection<topic> topics { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class election
    {
        public int id_candidat { get; set; }
        public int nbreVote { get; set; }
        public Nullable<int> gamer_id { get; set; }
        public Nullable<int> id_vote { get; set; }
        public virtual gamer gamer { get; set; }
        public virtual vote vote { get; set; }
    }
}

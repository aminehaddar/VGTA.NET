using System;
using System.Collections.Generic;

namespace VGTA.Data.Models
{
    public partial class category
    {
        public category()
        {
            this.subcategories = new List<subcategory>();
        }

        public int id_category { get; set; }
        public string title { get; set; }
        public virtual ICollection<subcategory> subcategories { get; set; }
    }
}

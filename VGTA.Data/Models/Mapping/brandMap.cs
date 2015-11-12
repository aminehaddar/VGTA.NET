using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class brandMap : EntityTypeConfiguration<brand>
    {
        public brandMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.brand1)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("brand", "vgta");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.brand1).HasColumnName("brand");
        }
    }
}

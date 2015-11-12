using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class categoryMap : EntityTypeConfiguration<category>
    {
        public categoryMap()
        {
            // Primary Key
            this.HasKey(t => t.id_category);

            // Properties
            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("category", "vgta");
            this.Property(t => t.id_category).HasColumnName("id_category");
            this.Property(t => t.title).HasColumnName("title");
        }
    }
}

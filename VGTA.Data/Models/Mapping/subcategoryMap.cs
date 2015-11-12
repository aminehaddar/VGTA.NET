using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class subcategoryMap : EntityTypeConfiguration<subcategory>
    {
        public subcategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.id_subcategory);

            // Properties
            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("subcategory", "vgta");
            this.Property(t => t.id_subcategory).HasColumnName("id_subcategory");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.id_category).HasColumnName("id_category");

            // Relationships
            this.HasOptional(t => t.category)
                .WithMany(t => t.subcategories)
                .HasForeignKey(d => d.id_category);

        }
    }
}

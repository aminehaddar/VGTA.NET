using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class typeeventMap : EntityTypeConfiguration<typeevent>
    {
        public typeeventMap()
        {
            // Primary Key
            this.HasKey(t => t.id_type);

            // Properties
            this.Property(t => t.type_event)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("typeevent", "vgta");
            this.Property(t => t.id_type).HasColumnName("id_type");
            this.Property(t => t.type_event).HasColumnName("type_event");
        }
    }
}

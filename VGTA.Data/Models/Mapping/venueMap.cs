using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class venueMap : EntityTypeConfiguration<venue>
    {
        public venueMap()
        {
            // Primary Key
            this.HasKey(t => t.id_venue);

            // Properties
            this.Property(t => t.adress)
                .HasMaxLength(255);

            this.Property(t => t.city)
                .HasMaxLength(255);

            this.Property(t => t.latitude)
                .HasMaxLength(255);

            this.Property(t => t.longitude)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("venue", "vgta");
            this.Property(t => t.id_venue).HasColumnName("id_venue");
            this.Property(t => t.adress).HasColumnName("adress");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.latitude).HasColumnName("latitude");
            this.Property(t => t.longitude).HasColumnName("longitude");
        }
    }
}

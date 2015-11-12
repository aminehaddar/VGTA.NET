using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class participantMap : EntityTypeConfiguration<participant>
    {
        public participantMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("participant", "vgta");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.checked_in).HasColumnName("checked_in");
            this.Property(t => t.checked_in_at).HasColumnName("checked_in_at");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.tournament_id).HasColumnName("tournament_id");

            // Relationships
            this.HasOptional(t => t.tournament)
                .WithMany(t => t.participants)
                .HasForeignKey(d => d.tournament_id);

        }
    }
}

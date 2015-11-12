using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class tournamentMap : EntityTypeConfiguration<tournament>
    {
        public tournamentMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.state)
                .HasMaxLength(255);

            this.Property(t => t.subdomain)
                .HasMaxLength(255);

            this.Property(t => t.tournament_type)
                .HasMaxLength(255);

            this.Property(t => t.url)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tournament", "vgta");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.created_after).HasColumnName("created_after");
            this.Property(t => t.created_before).HasColumnName("created_before");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hold_third_place_match).HasColumnName("hold_third_place_match");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.show_rounds).HasColumnName("show_rounds");
            this.Property(t => t.signup_cap).HasColumnName("signup_cap");
            this.Property(t => t.start_at).HasColumnName("start_at");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.subdomain).HasColumnName("subdomain");
            this.Property(t => t.tournament_type).HasColumnName("tournament_type");
            this.Property(t => t.url).HasColumnName("url");
            this.Property(t => t.id_event).HasColumnName("id_event");

            // Relationships
            this.HasOptional(t => t.@event)
                .WithMany(t => t.tournaments)
                .HasForeignKey(d => d.id_event);

        }
    }
}

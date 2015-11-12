using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class eventMap : EntityTypeConfiguration<Event>
    {
        public eventMap()
        {
            // Primary Key
            this.HasKey(t => t.id_event);

            // Properties
            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.streaming)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("events", "vgta");
            this.Property(t => t.id_event).HasColumnName("id_event");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.nbrReservation).HasColumnName("nbrReservation");
            this.Property(t => t.streaming).HasColumnName("streaming");
            this.Property(t => t.teamOrganisation).HasColumnName("teamOrganisation");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.venue).HasColumnName("venue");

            // Relationships
            this.HasOptional(t => t.team)
                .WithMany(t => t.events)
                .HasForeignKey(d => d.teamOrganisation);
            this.HasOptional(t => t.venue1)
                .WithMany(t => t.events)
                .HasForeignKey(d => d.venue);
            this.HasOptional(t => t.typeevent)
                .WithMany(t => t.events)
                .HasForeignKey(d => d.type);

        }
    }
}

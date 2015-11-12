using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class electionMap : EntityTypeConfiguration<election>
    {
        public electionMap()
        {
            // Primary Key
            this.HasKey(t => t.id_candidat);

            // Properties
            // Table & Column Mappings
            this.ToTable("election", "vgta");
            this.Property(t => t.id_candidat).HasColumnName("id_candidat");
            this.Property(t => t.nbreVote).HasColumnName("nbreVote");
            this.Property(t => t.gamer_id).HasColumnName("gamer_id");
            this.Property(t => t.id_vote).HasColumnName("id_vote");

            // Relationships
            this.HasOptional(t => t.gamer)
                .WithMany(t => t.elections)
                .HasForeignKey(d => d.gamer_id);
            this.HasOptional(t => t.vote)
                .WithMany(t => t.elections)
                .HasForeignKey(d => d.id_vote);

        }
    }
}

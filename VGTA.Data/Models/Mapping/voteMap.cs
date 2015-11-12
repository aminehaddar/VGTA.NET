using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class voteMap : EntityTypeConfiguration<vote>
    {
        public voteMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("vote", "vgta");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.date_Fin).HasColumnName("date_Fin");
            this.Property(t => t.date_debut).HasColumnName("date_debut");
            this.Property(t => t.nbRequiredAdmin).HasColumnName("nbRequiredAdmin");
        }
    }
}

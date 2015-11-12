using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class topicMap : EntityTypeConfiguration<topic>
    {
        public topicMap()
        {
            // Primary Key
            this.HasKey(t => t.id_topic);

            // Properties
            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("topic", "vgta");
            this.Property(t => t.id_topic).HasColumnName("id_topic");
            this.Property(t => t.post_time).HasColumnName("post_time");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.id_gamer).HasColumnName("id_gamer");
            this.Property(t => t.id_subcategory).HasColumnName("id_subcategory");

            // Relationships
            this.HasOptional(t => t.gamer)
                .WithMany(t => t.topics)
                .HasForeignKey(d => d.id_gamer);
            this.HasOptional(t => t.subcategory)
                .WithMany(t => t.topics)
                .HasForeignKey(d => d.id_subcategory);

        }
    }
}

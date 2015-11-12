using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VGTA.Data.Models.Mapping
{
    public class messageMap : EntityTypeConfiguration<message>
    {
        public messageMap()
        {
            // Primary Key
            this.HasKey(t => t.id_msg);

            // Properties
            this.Property(t => t.message1)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("message", "vgta");
            this.Property(t => t.id_msg).HasColumnName("id_msg");
            this.Property(t => t.message1).HasColumnName("message");
            this.Property(t => t.post_time).HasColumnName("post_time");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.id_gamer).HasColumnName("id_gamer");
            this.Property(t => t.id_topic).HasColumnName("id_topic");

            // Relationships
            this.HasOptional(t => t.gamer)
                .WithMany(t => t.messages)
                .HasForeignKey(d => d.id_gamer);
            this.HasOptional(t => t.topic)
                .WithMany(t => t.messages)
                .HasForeignKey(d => d.id_topic);

        }
    }
}

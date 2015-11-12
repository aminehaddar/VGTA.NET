using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using VGTA.Data.Models.Mapping;

namespace VGTA.Data.Models
{
    public partial class vgtaContext : DbContext
    {
        static vgtaContext()
        {
            Database.SetInitializer<vgtaContext>(null);
        }

        public vgtaContext()
            : base("Name=vgtaContext")
        {
        }

        public IDbSet<administrator> administrators { get; set; }
        public IDbSet<article> articles { get; set; }
        public IDbSet<brand> brands { get; set; }
        public IDbSet<category> categories { get; set; }
        public IDbSet<contribution> contributions { get; set; }
        public IDbSet<election> elections { get; set; }
        public IDbSet<equipment> equipments { get; set; }
        public IDbSet<Event> events { get; set; }
        public IDbSet<gamer> gamers { get; set; }
        public IDbSet<message> messages { get; set; }
        public IDbSet<participant> participants { get; set; }
        public IDbSet<sponsor> sponsors { get; set; }
        public IDbSet<subcategory> subcategories { get; set; }
        public IDbSet<team> teams { get; set; }
        public IDbSet<topic> topics { get; set; }
        public IDbSet<tournament> tournaments { get; set; }
        public IDbSet<trophy> trophies { get; set; }
        public IDbSet<typeequipment> typeequipments { get; set; }
        public IDbSet<typeevent> typeevents { get; set; }
        public IDbSet<venue> venues { get; set; }
        public IDbSet<vote> votes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new administratorMap());
            modelBuilder.Configurations.Add(new articleMap());
            modelBuilder.Configurations.Add(new brandMap());
            modelBuilder.Configurations.Add(new categoryMap());
            modelBuilder.Configurations.Add(new contributionMap());
            modelBuilder.Configurations.Add(new electionMap());
            modelBuilder.Configurations.Add(new equipmentMap());
            modelBuilder.Configurations.Add(new eventMap());
            modelBuilder.Configurations.Add(new gamerMap());
            modelBuilder.Configurations.Add(new messageMap());
            modelBuilder.Configurations.Add(new participantMap());
            modelBuilder.Configurations.Add(new sponsorMap());
            modelBuilder.Configurations.Add(new subcategoryMap());
            modelBuilder.Configurations.Add(new teamMap());
            modelBuilder.Configurations.Add(new topicMap());
            modelBuilder.Configurations.Add(new tournamentMap());
            modelBuilder.Configurations.Add(new trophyMap());
            modelBuilder.Configurations.Add(new typeequipmentMap());
            modelBuilder.Configurations.Add(new typeeventMap());
            modelBuilder.Configurations.Add(new venueMap());
            modelBuilder.Configurations.Add(new voteMap());
        }
    }
}

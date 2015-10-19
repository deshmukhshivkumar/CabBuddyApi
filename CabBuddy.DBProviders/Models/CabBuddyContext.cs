using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CabBuddy.DBProviders.Models.Mapping;

namespace CabBuddy.DBProviders.Models
{
    public partial class CabBuddyContext : DbContext
    {
        static CabBuddyContext()
        {
            Database.SetInitializer<CabBuddyContext>(null);
        }

        public CabBuddyContext()
            : base("Name=CabBuddyContext")
        {
        }

        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GroupMap());
        }
    }
}

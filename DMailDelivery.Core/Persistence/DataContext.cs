using System.Data.Entity;
using DMailDelivery.Core.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DMailDelivery.Core.Persistence
{
    public partial class DataContext : DbContext
    {
        public DataContext() : base(nameOrConnectionString: "localhost_database") { }

        public DbSet<Email> Emails { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Sender> Senders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new PropertyConvention());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();            
            base.OnModelCreating(modelBuilder);
        }
    }
}
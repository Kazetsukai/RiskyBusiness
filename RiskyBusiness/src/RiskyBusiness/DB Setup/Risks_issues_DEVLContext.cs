using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace RiskyBusiness
{
    public partial class Risks_issues_DEVLContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=localhost\SQLEXPRESS2;Initial Catalog=Risks_issues_DEVL;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Risks>(entity =>
            {
                entity.Key(e => e.risk_key);
            });
        }

        public virtual DbSet<Risks> Risks { get; set; }
    }
}
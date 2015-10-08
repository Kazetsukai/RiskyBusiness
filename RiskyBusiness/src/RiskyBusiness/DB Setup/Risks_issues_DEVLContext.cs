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

                entity.Reference(d => d.project_task_referenceNavigation).InverseCollection(p => p.Risks).ForeignKey(d => d.project_task_reference);
            });

            modelBuilder.Entity<risk_projects>(entity =>
            {
                entity.Key(e => e.project_task_reference);

                entity.Property(e => e.account_manager).Required();

                entity.Property(e => e.actual_hours_recorded).HasColumnType("decimal(7, 1)");

                entity.Property(e => e.analysis_estimate).HasColumnType("decimal(7, 1)");
            });
        }

        public virtual DbSet<Risks> Risks { get; set; }
        public virtual DbSet<risk_projects> risk_projects { get; set; }
    }
}
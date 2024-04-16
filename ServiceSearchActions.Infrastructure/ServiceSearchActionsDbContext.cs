using Microsoft.EntityFrameworkCore;
using ServiceSearchActions.Core.Entites.Shares;
using System.Reflection;

namespace ServiceSearchActions.Infrastructure
{
    public class ServiceSearchActionsDbContext : DbContext
    {
        public DbSet<CompanyProfile> CompanyProfile {  get; set; }
        public ServiceSearchActionsDbContext(DbContextOptions<ServiceSearchActionsDbContext> options): base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

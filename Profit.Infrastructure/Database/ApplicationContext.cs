using Microsoft.EntityFrameworkCore;
using Profit.Domain.Models;
using Profit.Core;

namespace Profit.Infrastructure.Database
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public DbSet<Message> Messages { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)        
            : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ModelConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
using Cogna.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cogna.Infrastructure.Persistence
{
    public class CognaDbContext : DbContext
    {
        public CognaDbContext(DbContextOptions<CognaDbContext> options) : base(options)
        {

        }

        public DbSet<Todos> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Todos>(m =>
            {
                m.HasKey(k => k.IdTodos);
            });
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TeamCreationV2.Core.Entites;

namespace TeamCreationV2.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>opt): base(opt) { }

        public DbSet<Persons> Persons { get; set; }
        public DbSet<TeamRegistre> Teams { get; set; }
    }
}

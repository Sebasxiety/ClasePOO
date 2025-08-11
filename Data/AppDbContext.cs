using Microsoft.EntityFrameworkCore;
using ClasePOO.Models;

namespace ClasePOO.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes => Set<Cliente>();
    }
}

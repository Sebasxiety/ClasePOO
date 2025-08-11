using ClienteMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace ClienteMvc.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes => Set<Cliente>();
    }
}

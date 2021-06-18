using Microsoft.EntityFrameworkCore;
using LojaVirtual.Models;

namespace LojaVirtual.Data
{
    public class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext (DbContextOptions<LojaVirtualContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}

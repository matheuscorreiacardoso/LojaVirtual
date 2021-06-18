using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Models
{
    public class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext (DbContextOptions<LojaVirtualContext> options)
            : base(options)
        {
        }

        public DbSet<LojaVirtual.Models.Department> Department { get; set; }
    }
}

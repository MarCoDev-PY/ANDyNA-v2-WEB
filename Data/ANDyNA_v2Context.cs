using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ANDyNA_v2.Models;

namespace ANDyNA_v2.Data
{
    public class ANDyNA_v2Context : DbContext
    {
        public ANDyNA_v2Context (DbContextOptions<ANDyNA_v2Context> options)
            : base(options)
        {
        }

        public DbSet<ANDyNA_v2.Models.Canchas> Canchas { get; set; } = default!;
        public DbSet<ANDyNA_v2.Models.Clientes> Clientes { get; set; } = default!;
        public DbSet<ANDyNA_v2.Models.Usuarios> Usuarios { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LarreaPaulTaller1.Models;

namespace LarreaPaulTaller1.Data
{
    public class LarreaPaulTaller1Context : DbContext
    {
        public LarreaPaulTaller1Context (DbContextOptions<LarreaPaulTaller1Context> options)
            : base(options)
        {
        }

        public DbSet<LarreaPaulTaller1.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<LarreaPaulTaller1.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<LarreaPaulTaller1.Models.Jugador> Jugador { get; set; } = default!;
    }
}

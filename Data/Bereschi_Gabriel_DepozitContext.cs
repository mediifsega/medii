using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bereschi_Gabriel_Depozit.Models;

namespace Bereschi_Gabriel_Depozit.Data
{
    public class Bereschi_Gabriel_DepozitContext : DbContext
    {
        public Bereschi_Gabriel_DepozitContext (DbContextOptions<Bereschi_Gabriel_DepozitContext> options)
            : base(options)
        {
        }

        public DbSet<Bereschi_Gabriel_Depozit.Models.Depozit> Depozit { get; set; }

        public DbSet<Bereschi_Gabriel_Depozit.Models.Proprietar> Proprietar { get; set; }

        public DbSet<Bereschi_Gabriel_Depozit.Models.Produs> Produs { get; set; }
    }
}

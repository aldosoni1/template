using Microsoft.EntityFrameworkCore;
using PJENL.Domain.Models;
using PJENL.Infraestructure.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJENL.Infraestructure
{
    public class MascotaContext : DbContext
    {
        public MascotaContext(DbContextOptions<MascotaContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MascotaConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using PJENL.Domain.Models;
using PJENL.Domain.Repositories;
using PJENL.Shared.Kernel.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJENL.Infraestructure.Repositories
{
    public class MascotaRepository : Repository<Mascota, Guid>, IMascotaRepository
    {
        private readonly MascotaContext _context;
        private readonly DbSet<Mascota> _dbSet;
        public MascotaRepository(MascotaContext context) : base(context)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            _context = context;
            _dbSet = _context.Set<Mascota>();
        }
        public async Task<IEnumerable<Mascota>> GetMascotas()
        {
            return await _dbSet.ToListAsync();
        }

        public IQueryable<Mascota> GetQueryMascotas()
        {
            return _dbSet;
        }
    }
}

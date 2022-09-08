using PJENL.Domain.Models;
using PJENL.Shared.Kernel.DomainUtils.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJENL.Domain.Repositories
{
    public interface IMascotaRepository : IRepository<Mascota,Guid>
    {
        Task<IEnumerable<Mascota>> GetMascotas();
        IQueryable<Mascota> GetQueryMascotas();
    }
}

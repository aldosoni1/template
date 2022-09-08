using Microsoft.EntityFrameworkCore;
using PJENL.Application.Services.Mascota.Dtos.InputModel;
using PJENL.Application.Services.Mascota.Dtos.OutputModel;
using PJENL.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJENL.Application.Services.Mascota
{
    public class MascotaService : IMascotaService
    {
        private readonly IMascotaRepository _mascotaRepository;
        public MascotaService(IMascotaRepository mascotaRepository)
        {
            _mascotaRepository = mascotaRepository;
        }
        public async Task<IEnumerable<MascotaOutputModel>> GetMascotas()
        {
            IEnumerable<Domain.Models.Mascota> mascotasDb = await _mascotaRepository.GetMascotas();
            return mascotasDb.Select(x => new MascotaOutputModel(x.Id, x.Nombre));
        }

        public async Task<IEnumerable<MascotaEspecieOutputModel>> GetMascotasWithEspecie()
        {
            return await _mascotaRepository.GetQueryMascotas().Include(x => x.Especie)
                .Select(x => new MascotaEspecieOutputModel(x.Nombre, x.Id, x.Especie.Descripcion)).ToListAsync();
        }

        public async Task<MascotaOutputModel> Registrar(RegistrarMascotaInputModel registrarMascotaInputModel)
        {
            var moscotaARegistrar = new Domain.Models.Mascota(registrarMascotaInputModel.Nombre, registrarMascotaInputModel.IdEspecie);
            var mascotaRegistradaEf = await _mascotaRepository.AddRepositoryAsync(moscotaARegistrar);
            return new MascotaOutputModel(mascotaRegistradaEf.Id, mascotaRegistradaEf.Nombre);

        }
    }
}

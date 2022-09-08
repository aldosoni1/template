using PJENL.Application.Services.Mascota.Dtos.InputModel;
using PJENL.Application.Services.Mascota.Dtos.OutputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJENL.Application.Services.Mascota
{
    public interface IMascotaService
    {
        public Task<IEnumerable<MascotaOutputModel>> GetMascotas();
        public Task<IEnumerable<MascotaEspecieOutputModel>> GetMascotasWithEspecie();
        public Task<MascotaOutputModel> Registrar(RegistrarMascotaInputModel registrarMascotaInputModel);
    }
}

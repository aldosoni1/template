using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PJENL.Application.Services.Mascota;
using PJENL.Application.Services.Mascota.Dtos.InputModel;
using PJENL.Application.Services.Mascota.Dtos.OutputModel;
using PJENL.Domain.Exceptions;
using PJENL.Shared.Kernel.DomainUtils.Responses;
using System;

namespace PJENL.Mascotas.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        private readonly IMascotaService _mascotaService;
        public MascotaController(IMascotaService mascotaService)
        {
            _mascotaService = mascotaService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(Response<IEnumerable<MascotaOutputModel>>), 200)]
        [ProducesResponseType(typeof(Response), 400)]
        public async Task<IActionResult> GetAll()
        {
            //throw new PJENLException<CodigosRespuestaMascotas>(CodigosRespuestaMascotas.Error_01, System.Net.HttpStatusCode.BadRequest);
            DateTime fechaRequest = DateTime.UtcNow;
            IEnumerable<MascotaOutputModel> data = await _mascotaService.GetMascotas();
            Response<IEnumerable<MascotaOutputModel>> response =
                ResponseFactory.Build(data, CodigosRespuestaMascotas.Succes_02, true, System.Net.HttpStatusCode.OK, "Mensaje Personalizado desde el controlador", "Mensaje 2");
            response.AddRequestDate(fechaRequest);
            response.AddResponseDate(DateTime.UtcNow);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllWithEspecie()
        {
            var data = await _mascotaService.GetMascotasWithEspecie();
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> RegistrarMascota(RegistrarMascotaInputModel registrarMascotaInputModel)
        {

            DateTime fechaRequest = DateTime.UtcNow;
            var data = await _mascotaService.Registrar(registrarMascotaInputModel);
            Response<MascotaOutputModel> response =
                ResponseFactory.Build(data, CodigosRespuestaMascotas.Succes_02, true, System.Net.HttpStatusCode.OK, "Mensaje Personalizado desde el controlador", "Mensaje 2");
            response.AddRequestDate(fechaRequest);
            response.AddResponseDate(DateTime.UtcNow);
            return StatusCode(201,response);

        }
    }
}

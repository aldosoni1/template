using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJENL.Application.Services.Mascota.Dtos.OutputModel
{
    public class MascotaOutputModel
    {
        public Guid IdMascota { get; set; }
        [Required]
        [MinLength(100)]
        public string Nombre { get; set; }
        public MascotaOutputModel()
        {

        }

        public MascotaOutputModel(Guid idMascota, string nombre)
        {
            IdMascota = idMascota;
            Nombre = nombre;
        }
    }
}

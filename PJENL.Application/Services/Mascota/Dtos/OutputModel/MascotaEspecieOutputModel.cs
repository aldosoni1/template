using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJENL.Application.Services.Mascota.Dtos.OutputModel
{
    public class MascotaEspecieOutputModel
    {
        public MascotaEspecieOutputModel(string nombre, Guid id, string especie)
        {
            Nombre = nombre;
            Id = id;
            Especie = especie;
        }

        public string Nombre { get; private set; }
        public Guid Id { get; set; }
        public string Especie { get; set; }
    }
}

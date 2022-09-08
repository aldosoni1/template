using PJENL.Shared.Kernel.DomainUtils.DDD;
using System;
using System.Collections.Generic;
using System.Text;

namespace PJENL.Domain.Models
{
    public class Especie : ICatalogo<int>
    {
        public string Descripcion { get; set; }

        public int Id { get; set; }
        public virtual List<Mascota> Mascotas { get; private set; }
        protected Especie()
        {

        }
        public Especie(string descripcion)
        {
            Descripcion = descripcion;
        }
    }
}

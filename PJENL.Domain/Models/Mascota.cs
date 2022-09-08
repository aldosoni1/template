using System;
using System.Collections.Generic;
using System.Text;

namespace PJENL.Domain.Models
{
    public class Mascota
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public virtual Especie Especie { get; private set; }
        public int IdEspecie { get; private set; }
        protected Mascota()
        {

        }
        public void CambiarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("No se envio el parametro de nombre al cambiar el nombre");
            Nombre = nombre;
        }
        public Mascota(string nombre, int idEspecie)
        {
            Nombre = nombre;
            IdEspecie = idEspecie;
        }
    }
}

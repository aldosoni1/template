using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PJENL.Domain.Exceptions
{
    public enum CodigosRespuestaMascotas
    {
        [Description("Se obtubieron las mascotas {0}")]
        Succes_01 = 1,
        [Description("{0}, {1}")]
        Succes_02 = 50001,
        [Description("Error controlado")]
        Error_01 = 000002,
    }
}

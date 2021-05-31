using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cornec_guillermo_lppa_parcial1.Data.Entities
{
    public class Afiliado : IdentityBase
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Email { get; set; }

        public string CUIT { get; set; }

        public string Telefono { get; set; }

    }
}
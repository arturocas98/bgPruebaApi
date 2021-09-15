using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bdpPruebaApi.Models
{
    public class Login
    {
        public int id { get; set; }

        public string codigoRetorno { get; set; }

        public string token { get; set; }

        public int usuarioId { get; set; }

        [ForeignKey("usuarioId")]
        public Usuario usuario { get; set; }
    }
}

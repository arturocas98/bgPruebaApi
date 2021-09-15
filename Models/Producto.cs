using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bdpPruebaApi.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }

        public string descripcion { get; set; }

        public int precio { get; set; }

        public bool estado { get; set; }

        public string detalle { get; set; }

        public string imagen { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class FacturasServicios
    {
        [Key]

        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int ServicioId { get; set; }
    }
}

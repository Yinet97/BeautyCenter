using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empleadas
    {
        [Key]
        public int EmpleadaId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Servicio { get; set; }
        public int SueldoFijo { get; set; }
        public DateTime FechaEntrada { get; set; }
    }
}

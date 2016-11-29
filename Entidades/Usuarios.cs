using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    class Usuarios
    {
        [Key]

        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Tipo { get; set; }
    }
}

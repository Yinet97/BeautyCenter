using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposUsuarios
    {
        [Key]
        public string TipoCategoria { get; set; }
        public int TipoId { get; set; }
    }
}

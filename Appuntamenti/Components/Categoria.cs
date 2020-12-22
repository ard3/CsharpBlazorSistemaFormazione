using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Appuntamenti.Components
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Inserire nome categoria")]
        public string Nome { get; set; }
    }
}

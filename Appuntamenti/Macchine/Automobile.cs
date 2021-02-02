using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Appuntamenti.Macchine
{
    public class Automobile
    {
        public int Id;

        [Required(ErrorMessage = "Inserire targa")]
        public string Targa;

        public string Modello;
    }
}

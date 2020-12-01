using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appuntamenti.Components
{
    public class Impegno
    {
        public int Id { get; set; } // 1
        public string Cliente { get; set; } // Divani e Divani
        public DateTime Quando { get; set; } // 02/12/2020 09:00:00
        public string Localita { get; set; } // Firenze
        public bool Confermato { get; set; } // true
        public string Assegnatario { get; set; } // Daniele
    }
}

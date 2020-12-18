using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Appuntamenti.Components
{
    public class Impegno
    {
        public int Id { get; set; } // 1

        [Required(ErrorMessage = "Inserire cliente.")]
        public string Cliente { get; set; } // Divani e Divani

        [Required(ErrorMessage = "Inserire data.")]
        public DateTime Quando { get; set; } // 02/12/2020 09:00:00

        [Required(ErrorMessage = "Indicare la località dell'incontro.")]
        [StringLength(50, ErrorMessage = "Il campo 'Località' accetta un massimo 50 caratteri.")]
        public string Localita { get; set; } // Firenze

        public bool Confermato { get; set; } // true

        public string Assegnatario { get; set; } // Daniele
    }
}

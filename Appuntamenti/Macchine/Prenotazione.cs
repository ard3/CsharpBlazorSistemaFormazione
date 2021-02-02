using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Appuntamenti.Macchine
{
    public class Prenotazione
    {
        public int Id;

        [Required(ErrorMessage = "Inserire auto")]
        public int IdAuto;

        [Required(ErrorMessage = "Inserire nome")]
        public string Chi;

        [Required(ErrorMessage = "Inserire data di inizio prenotazione")]
        public DateTime Inizio;

        [Required(ErrorMessage = "Inserire data di fine prenotazione")]
        public DateTime Fine;

        [Required(ErrorMessage = "Inserire destinazione")]
        public string Dove;
    }
}

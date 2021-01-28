using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Appuntamenti.Components
{
    public class Prodotto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Inserire nome prodotto")]
        public string Nome { get; set; }

        public double Prezzo { get; set; }

        public int IdCategoria { get; set; }

    }
}

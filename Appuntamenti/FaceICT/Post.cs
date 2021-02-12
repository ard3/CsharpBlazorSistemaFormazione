using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Appuntamenti.FaceICT
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Inserire nome utente")]
        public string Utente { get; set; }

        public DateTime Data { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Inserire il contenuto del post")]
        public string Contenuto { get; set; }

        public bool Modificato { get; set; } = false;
    }
}

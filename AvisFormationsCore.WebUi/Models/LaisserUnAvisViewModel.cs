using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationsCore.WebUi.Models
{
    public class LaisserUnAvisViewModel
    {
        [StringLength(5)]
        public string Commentaire { get; set; }

        [Required]
        public string Nom { get; set; }
        
        [Required]
        public string Note { get; set; }

        [Required]
        public string IdFormation { get; set; }
    }
}

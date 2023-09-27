using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityVoiturePersonneAdresse.Entities
{
    public class Voiture
    {

        [Key]
        [MaxLength(17)]
        public string Frame { get; set; }

        [Required]
        [MaxLength(20)]
        public string Plate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Color { get; set; }

        [Required]
        [MaxLength(50)]
        public string Brand { get; set; }

        [Required]
        public Personne Owner { get; set; }
    }
}

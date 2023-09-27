using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityVoiturePersonneAdresse.Entities
{
    public class Adresse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Rue { get; set; }

        [Required]
        [MaxLength(10)]
        public string Numero { get; set; }

        [Required]
        [MaxLength(15)]
        public string CP { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }
    }
}

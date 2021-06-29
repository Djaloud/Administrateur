using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class Module
    {
        [Key]
        public int moduleId { get; set; }
        public string nom { get; set; }
        [ForeignKey("Professeur")]
        public Professeur responsable { get; set; }
        public int filiereId { get; set; }
        [ForeignKey("Filiere")]
        public Filiere filiere { get; set; }

    }
}

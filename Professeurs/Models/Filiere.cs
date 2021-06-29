using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class Filiere
    {
        [Key]
        public int filiereId { get; set; }
        public string nom { get; set; }
        [ForeignKey("Professeur")]
        public Professeur coordinateur { get; set; }
        public List<Etudiant> etudiants { get; set; }
        public List<Module> modules { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class Professeur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_professeur { get; set; }
        public String nom_prof { get; set; }
        public String prenom_prof { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String adresse { get; set; }


        [ForeignKey("departementId")]
        public String? departementId { get; set; }

        
    }
}

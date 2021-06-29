using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class Etudiant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int apogee { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String adresse { get; set; }
        public String massar { get; set; }
        public String cin { get; set; }
        public String lastname_fr { get; set; }
        public String lastname_ar { get; set; }
        public String firstname_fr { get; set; }
        public String firstname_ar { get; set; }
        public String ddn { get; set; }
        public String ldn { get; set; }
        public String natio { get; set; }
        public String phone { get; set; }
        public String father_name { get; set; }
        public String father_job { get; set; }
        public String mother_name { get; set; }
        public String mother_job { get; set; }
        public String parents_adress { get; set; }
        public String parents_phone { get; set; }
        public String annee { get; set; }
        public String filiere { get; set; }
        public String type_bac { get; set; }
        public String mention_bac { get; set; }
        public String annee_bac { get; set; }
        public String lycee { get; set; }
        public String delegation { get; set; }
        public String academie { get; set; }
        public String diplome { get; set; }
        public String ecole { get; set; }
        public String ville_diplome { get; set; }
        public String picture { get; set; }
        public int validated { get; set; }
        public String password { get; set; }
        public int code_promo { get; set; }
        public String sexe { get; set; }

        public Etudiant(int apogee, String nom, String prenom, String email, String annee)
        {
            this.apogee = apogee;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.annee = annee;

        }
        public virtual IList<Etudiant> etudiant { get; set; }

        public Etudiant()
        {

        }
    }


}


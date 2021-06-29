using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class Departement
    {
        [Key]
        public int departementId{get;set;}
        public string nom { get; set; }

    }
}

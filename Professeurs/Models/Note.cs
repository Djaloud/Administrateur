using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string semestre { get; set; }
        public int note { get; set; }
        public int filiereId { get; set; }
        [ForeignKey("Filiere")]
        public Filiere filiere { get; set; }
    }
}

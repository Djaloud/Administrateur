using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class ProfesseurMap 
    {
        public ProfesseurMap(EntityTypeBuilder<Professeur> entityBuilder)
        {
            entityBuilder.HasKey(t => t.id_professeur);
            entityBuilder.Property(t => t.nom_prof).IsRequired();
            entityBuilder.Property(t => t.prenom_prof).IsRequired();
            entityBuilder.Property(t => t.tel).IsRequired();
            entityBuilder.Property(t => t.adresse).IsRequired();
            entityBuilder.Property(t => t.departementId).IsRequired();
            entityBuilder.Property(t => t.email).IsRequired();

        }
    }
}

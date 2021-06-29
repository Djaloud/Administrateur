using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Models
{
    public class myDataContext : DbContext
    {
        public myDataContext(DbContextOptions option):base(option)
        {
        }

        public object Professeur { get; internal set; }
        public DbSet<Etudiant> etudiants { get; set; }
        public DbSet<Filiere> filieres { get; set; }
        public DbSet<Module> modules { get; set; }
        public DbSet<Professeur> professeurs { get; set; }
        public DbSet<Note> notes { get; set; }
        public DbSet<Departement> departements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ProfesseurMap(modelBuilder.Entity<Professeur>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("EtudiantDatabase");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

    }
}

using EntityVoiturePersonneAdresse.Configs;
using EntityVoiturePersonneAdresse.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityVoiturePersonneAdresse.Context
{
    internal class DatabaseContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=voitureEntity;Trusted_Connection=True;");
        }

        public DbSet<Adresse> adresses { get; set; }
        public DbSet<Personne> personnes { get; set; }
        public DbSet<Voiture> voitures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonneConfig());
            modelBuilder.ApplyConfiguration(new VoitureConfig());
        }

    }
}

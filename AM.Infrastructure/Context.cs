//using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AM.Infrastructure
{
    public class Context: DbContext
    {
        public DbSet<Joueur> joueurs { get; set; } 
        public DbSet<Pays> Pays { get; set; } 
        public DbSet<Jouer> Jouers { get; set; } 
        public DbSet<Tournoi> Tournoi { get; set; } 
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   
           optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=NomPrenom;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JouerConf());
            modelBuilder.ApplyConfiguration(new PaysConf());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
           
        }

    }
}

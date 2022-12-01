using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class JouerConf : IEntityTypeConfiguration<Jouer>
    {
        public void Configure(EntityTypeBuilder<Jouer> builder)
        {
            builder.HasKey(t => new
            {
                t.JoeurFK,
                t.TournoiFK
            });
            builder.HasOne(t => t.Joueur).WithMany(f => f.Jouers).HasForeignKey(t => t.JoeurFK);
            builder.HasOne(t => t.Tournoi).WithMany(f => f.Jouers).HasForeignKey(t => t.TournoiFK);
            
        }
    }
}

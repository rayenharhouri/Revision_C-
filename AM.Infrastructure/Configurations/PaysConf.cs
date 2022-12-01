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
    public class PaysConf : IEntityTypeConfiguration<Pays>
    {
        public void Configure(EntityTypeBuilder<Pays> builder)
        {
            builder.HasMany(t => t.joueurs).WithOne(t => t.Pays).HasForeignKey(t => t.PaysFk);
        }
    }
}

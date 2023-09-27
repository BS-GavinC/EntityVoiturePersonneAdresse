using EntityVoiturePersonneAdresse.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityVoiturePersonneAdresse.Configs
{
    internal class VoitureConfig : IEntityTypeConfiguration<Voiture>
    {
        public void Configure(EntityTypeBuilder<Voiture> builder)
        {
            builder.HasIndex(x => x.Plate).IsUnique();
        }
    }
}

using Mangatheque.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Infrastructure.Databases.EntityConfigurations
{
    public class MangaEntityTypeConfiguration : IEntityTypeConfiguration<Manga>
    {
        public void Configure(EntityTypeBuilder<Manga> builder)
        {
            builder.Property(item => item.Nom).IsRequired();
            builder.Property(item=>item.Numero).IsRequired();
            builder.Property(item=>item.Auteur).IsRequired();
            builder.Property(item=>item.Couverture).IsRequired();
            builder.Property(item=>item.DatePublication).IsRequired();
            builder.Property(item => item.Genre).IsRequired();
        }
    }
}

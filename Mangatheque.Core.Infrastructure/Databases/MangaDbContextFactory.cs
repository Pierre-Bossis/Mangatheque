using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Infrastructure.Databases
{
    public class MangaDbContextFactory : IDesignTimeDbContextFactory<MangaDbContext>
    {
        public MangaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MangaDbContext>();

            optionsBuilder.UseSqlServer("Server=DESKTOP-J2KFRML;Database=Mangatheque;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new MangaDbContext(optionsBuilder.Options);
        }
    }
}
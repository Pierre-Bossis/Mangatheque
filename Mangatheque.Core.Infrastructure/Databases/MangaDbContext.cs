using Mangatheque.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Infrastructure.Databases
{
    public class MangaDbContext : DbContext
    {
        #region Properties
        public DbSet<Manga> Mangas { get; set; }
        #endregion

        #region Constructors
        public MangaDbContext(DbContextOptions<MangaDbContext> options) : base(options)
        {
            
        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntityConfigurations.MangaEntityTypeConfiguration());
        }
    }
}

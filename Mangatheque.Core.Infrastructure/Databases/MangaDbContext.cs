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
        public DbSet<MangathequeUser> Users { get; set; }
        public DbSet<Manga_MangathequeUser> manga_MangathequeUser { get; set; }
        #endregion

        #region Constructors
        public MangaDbContext(DbContextOptions<MangaDbContext> options) : base(options)
        {
            
        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntityConfigurations.MangaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.StockEntityTypeConfiguration());

            modelBuilder.Entity<Manga_MangathequeUser>()
            .HasKey(mu => new { mu.MangathequeUserId, mu.MangaId });

            modelBuilder.Entity<Manga_MangathequeUser>()
            .HasOne(mu => mu.MangathequeUser)
            .WithMany(u => u.UserMangas)
            .HasForeignKey(mu => mu.MangathequeUserId);

            modelBuilder.Entity<Manga_MangathequeUser>()
            .HasOne(mu => mu.Manga)
            .WithMany(m => m.UserMangas)
            .HasForeignKey(mu => mu.MangaId);

        }
    }
}

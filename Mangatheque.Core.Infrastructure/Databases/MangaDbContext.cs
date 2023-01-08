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
        //public DbSet<User> Users { get; set; }
        public DbSet<Manga> Mangas { get; set; }
        //public DbSet<MangasUser> MangaUsers { get; set; }
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

            /*modelBuilder.Entity<MangasUser>()
            .HasKey(mu => new { mu.UserId, mu.MangaId });
            modelBuilder.Entity<MangasUser>()
            .HasOne(mu => mu.User)
            .WithMany(u => u.MangasUser)
            .HasForeignKey(mu => mu.UserId);
            modelBuilder.Entity<MangasUser>()
            .HasOne(mu => mu.Manga)
            .WithMany(m => m.MangasUser)
            .HasForeignKey(mu => mu.MangaId);*/

        }
    }
}

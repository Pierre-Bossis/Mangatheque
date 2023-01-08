//using Mangatheque.Web.UI.Areas.Identity.Data;
using Mangatheque.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Mangatheque.Core.Infrastructure.Databases;

public class MangathequeWebUIContext : IdentityDbContext<MangathequeUser, IdentityRole, string>
{
    public MangathequeWebUIContext(DbContextOptions<MangathequeWebUIContext> options)
        : base(options)
    {
    }

    //public DbSet<Manga> Mangas { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /*builder.Entity<User>()
       .HasMany(u => u.MangasUser)
       .WithMany(m => m.User)
       .UsingEntity<UserManga>()
       .HasForeignKey(um => um.UsersId)
       .HasPrincipalKey(um => um.MangaId);*/

        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }


}

//using Mangatheque.Web.UI.Areas.Identity.Data;
using Mangatheque.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Mangatheque.Core.Infrastructure.Databases;

public class MangathequeWebUIContext : IdentityDbContext<MangathequeUser, IdentityRole, string>
{
    #region Properties
    //public override DbSet<MangathequeUser> Users { get; set; }
    //public DbSet<Manga> Mangas { get; set; }
    //public DbSet<Manga_MangathequeUser> manga_MangathequeUser { get; set; }
    #endregion

    public MangathequeWebUIContext(DbContextOptions<MangathequeWebUIContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }


}

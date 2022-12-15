using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Infrastructure.Databases
{
    public class MangathequeWebUIContextFactory : IDesignTimeDbContextFactory<MangathequeWebUIContext>
    {
        public MangathequeWebUIContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MangathequeWebUIContext>();

            optionsBuilder.UseSqlServer("Server=DESKTOP-J2KFRML;Database=Mangatheque;Trusted_Connection=True;TrustServerCertificate=true;");

            return new MangathequeWebUIContext(optionsBuilder.Options);
        }
    }
}

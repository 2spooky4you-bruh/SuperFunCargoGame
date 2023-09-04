using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFunCargoGame.Identity
{
    public class IdentityDbContextFactory : IDesignTimeDbContextFactory<ApplicationIdentityDbContext>
    {
        public ApplicationIdentityDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationIdentityDbContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=Identity;Trusted_Connection=True;TrustServerCertificate=True");

            return new ApplicationIdentityDbContext(optionsBuilder.Options);
        }
    }
}

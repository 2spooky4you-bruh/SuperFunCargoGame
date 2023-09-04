using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SuperFunCargoGame.Identity
{
    public class ApplicationIdentityDbContext : IdentityDbContext<ApplicationyUser>
    {
        public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options) : base(options) { }

    }
}

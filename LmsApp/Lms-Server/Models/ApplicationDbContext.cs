
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Lms.Server.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<AspNetResource> AspNetResources { get; set; }
        public IDbSet<AspNetPermission> AspNetPermissions { get; set; }

        public System.Data.Entity.DbSet<Lms.Server.Models.ApplicationRole> IdentityRoles { get; set; }
    }
}

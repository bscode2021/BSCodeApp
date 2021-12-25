using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // any guid
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            // any guid, but nothing is against to use the same one
            const string ADMIN_ROLE_ID = "0210B079-1500-43DE-B416-C3CEC926C7B2";
            const string STUDENT_ROLE_ID = "38ED837C-DFF4-4E5F-ACF0-367C9FA337FE";

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ADMIN_ROLE_ID,
                    Name = "admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = STUDENT_ROLE_ID,
                    Name = "student",
                    NormalizedName = "STUDENT"
                }
                );

            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = ADMIN_ID,
                UserName = "admin@bscode.net",
                NormalizedUserName = "admin@bscode.net",
                Email = "admin@bscode.net",
                NormalizedEmail = "admin@bscode.net",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin1234!"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using ManMinusData.Entities.Business;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ManMinusData.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //User and Role seeding
            Guid ADMIN_ID = new Guid("592FDCB8-75A3-4F4D-AFE8-C5C8648B3026");
            Guid ROLE_ID = new Guid("96D5AFDC-18BD-4D01-9ECB-0B8BA81DB4E6");
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = ROLE_ID,
                Name = "Admin",
                NormalizedName = "Admin",
                Description = "Administrator"

            });

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "Admin",
                Email = "jinnguyen1200@gmail.com",
                NormalizedEmail = "jinnguyen1200@gmail.com",
                EmailConfirmed = false,
                PasswordHash = hasher.HashPassword(null, "123456"),
                SecurityStamp = string.Empty,
                FullName = "Administrator"
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}

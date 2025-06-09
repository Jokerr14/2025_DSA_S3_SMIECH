using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.User;
using DSaA_Project_TimeTracker.Utils;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database;

public class Seeder
{
    public void Seed()
    {
        using (var context = new TTDbContext())
        {
            if (context.Database.CanConnect())
            {
                if (!context.Roles.Any())
                {
                    var roles = GetRoles();
                    context.Roles.AddRange(roles);
                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    var admin = SeedAdmin();
                    context.Users.Add(admin);
                    context.SaveChanges();
                }
            }
        }
    }

    private User SeedAdmin()
    {
        var admin = new User()
        {
            Username = "admin",
            Email = "admin@admin.pl",
            RoleId = 1,
            EmploymentStatus = "Employed"
        };

        admin.PasswordHash = PasswordHasher.HashPasword("admin", out var salt);
        admin.Salt = Convert.ToHexString(salt);

        return admin;
    }

    private IEnumerable<Role> GetRoles()
    {
        var roles = new List<Role>()
        {
            new Role() { Id = 1, RoleName = "Admin"},
            new Role() { Id = 2, RoleName = "Employee"}
        };

        return roles;
    }
}

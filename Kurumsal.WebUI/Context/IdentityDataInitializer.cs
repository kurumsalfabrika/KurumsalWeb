using Kurumsal.WebUI.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

public static class IdentityDataInitializer
{
    public static async Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
    {
        await SeedRoles(roleManager);
        await SeedUsers(userManager);
    }

    private static async Task SeedRoles(RoleManager<AppRole> roleManager)
    {
        if (!roleManager.Roles.Any())
        {
            var roles = new string[] { "Admin", "User" };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new AppRole { Name = role });
                }
            }
        }
    }

    private static async Task SeedUsers(UserManager<AppUser> userManager)
    {
        if (!userManager.Users.Any())
        {
            var user = new AppUser
            {
                UserName = "admin@ksmart.com.tr",
                Email = "admin@ksmart.com.tr",
                EmailConfirmed=true
            };

            var userResult = await userManager.CreateAsync(user, "Password123!");
            if (userResult.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}

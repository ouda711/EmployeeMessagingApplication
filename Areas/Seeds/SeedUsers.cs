using Microsoft.AspNetCore.Identity;

namespace EmployeeMessagingApplication.Areas.Seeds
{
    public static class SeedUsers
    {
        public static async Task SeedUsersAndRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            // Define roles and users
            var roles = new[] { "Admin", "Manager", "Employee" };
            var defaultPassword = "P@ssw0rd!";

            var users = new[]
            {
                new { Email = "admin@example.com", Role = "Admin" },
                new { Email = "manager@example.com", Role = "Manager" },
                new { Email = "employee@example.com", Role = "Employee" }
            };

            // Seed Roles
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            // Seed Users
            foreach (var user in users)
            {
                if (await userManager.FindByEmailAsync(user.Email) == null)
                {
                    var identityUser = new IdentityUser
                    {
                        UserName = user.Email,
                        Email = user.Email,
                        EmailConfirmed = true // Ensure the account is verified
                    };

                    var result = await userManager.CreateAsync(identityUser, defaultPassword);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(identityUser, user.Role);
                    }
                    else
                    {
                        throw new Exception($"Failed to create user {user.Email}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                    }
                }
            }
        }
    }
}

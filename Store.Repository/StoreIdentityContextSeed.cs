using Microsoft.AspNetCore.Identity;
using Store.Data.Entities.IdentityEntites;

namespace Store.Repository
{
    public class StoreIdentityContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "admin",
                    Email = "admin@gmail.com",
                    UserName = "adminuser",
                    Address = new Address
                    {
                        Firstname = "admin",
                        Lastname = "user",
                        city = "Maddi",
                        state = "Cairo",
                        street = "5",
                        PostalCode = "12345"
                    }
                };
                await userManager.CreateAsync(user, "Admin123#");
            }
        }
    }
}

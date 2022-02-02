using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using refresh_tokens_api.Data.Entities;
using System.Linq;
using BCryptNet = BCrypt.Net.BCrypt;

namespace refresh_tokens_api.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            if (!context.Users.Any())
            {
                context.Users.AddRange(new User()
                {
                    FirstName = "Test",
                    LastName = "User",
                    Username = "test",
                    PasswordHash = BCryptNet.HashPassword("test")
                },
                new User()
                {
                    FirstName = "Corneliu",
                    LastName = "Man",
                    Username = "mcv4clj",
                    PasswordHash = BCryptNet.HashPassword("mcv4clj")
                });

                context.SaveChanges();
            }
        }
    }
}

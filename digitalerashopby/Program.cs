using DLL.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace digitalerashopby
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                //var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                var rolesManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                //await RoleInitializer.InitializeAsync(userManager, rolesManager);
                //try
                //{

                //}
                //catch (Exception ex)
                //{
                //    var logger = services.GetRequiredService<ILogger<Program>>();
                //    logger.LogError(ex, "An error occurred while seeding the database.");
                //}
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace apiGerencia.Tests.IntegrationTest
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            var contentRoot = Environment.GetEnvironmentVariable("CONTENT_ROOT_PATH");
            if (!string.IsNullOrEmpty(contentRoot))
            {
                builder.UseContentRoot(contentRoot);
            }
            else
            {
                builder.UseContentRoot("C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\reposito\\apiGerencia");
            }
            builder.ConfigureServices(services =>
            {
                var serviceProvider = new ServiceCollection()
                    .BuildServiceProvider();

                services.AddSingleton(serviceProvider);

                var sp = services.BuildServiceProvider();

                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var logger = scopedServices.GetRequiredService<ILogger<CustomWebApplicationFactory<TStartup>>>();

                    logger.LogInformation("Starting test server...");
                }
            });
        }
    }
}

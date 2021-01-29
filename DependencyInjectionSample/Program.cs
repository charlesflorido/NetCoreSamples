using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

using DependencyInjectionSample.Services;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {

            IServiceCollection services = new ServiceCollection();
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true).Build();

            services.Configure<UserCredential>(configuration.GetSection("Credentials"));
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IExecution, MainExecution>();     

            IServiceProvider provider = services.BuildServiceProvider();

            var execution = provider.GetService<IExecution>();
            execution.Execute();
            
        }
    }
}

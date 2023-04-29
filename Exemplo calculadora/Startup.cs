using Microsoft.Extensions.DependencyInjection;

namespace ExemploCalculadora
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICalculadora, Calculadora>();
        }
    }
}
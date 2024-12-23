using Service;
using Service.Interfaces;

namespace API.IOC
{
    public static class ServicesIOC
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}

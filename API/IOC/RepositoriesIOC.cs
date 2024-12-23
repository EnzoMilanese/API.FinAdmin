using Database.Interfaces;
using Database.Repositories;
using Domain.Entities;

namespace API.IOC
{
    public static class RepositoriesIOC
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICRUDRepository<Usuario>, UsuarioRepository>();
        }
    }
}

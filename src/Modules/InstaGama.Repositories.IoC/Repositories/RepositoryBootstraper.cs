using InstaGama.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InstaGama.Repositories.IoC.Repositories
{
    internal class RepositoryBootstraper
    {
        internal void ChildServiceRegister(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IGenderRepository, GenderRepository>();
        }
    }
}

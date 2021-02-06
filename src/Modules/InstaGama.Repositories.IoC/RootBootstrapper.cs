using InstaGama.Repositories.IoC.Application;
using InstaGama.Repositories.IoC.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace InstaGama.Repositories.IoC
{
    public class RootBootstrapper
    {
        public void RootRegisterServices(IServiceCollection services)
        {
            new ApplicationBootstraper().ChildServiceRegister(services);
            new RepositoryBootstraper().ChildServiceRegister(services);
        }
    }
}

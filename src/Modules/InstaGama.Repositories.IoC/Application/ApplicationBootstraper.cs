using InstaGama.Application.AppPostage;
using InstaGama.Application.AppPostage.Interfaces;
using InstaGama.Application.AppUser;
using InstaGama.Application.AppUser.Interfaces;
using InstaGama.Domain.Core;
using InstaGama.Domain.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace InstaGama.Repositories.IoC.Application
{
    internal class ApplicationBootstraper
    {
        internal void ChildServiceRegister(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ILogged, Logged>();
            services.AddScoped<IStorageHelper, StorageHelper>();

            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<ILoginAppService, LoginAppService>();
            services.AddScoped<IPostageAppService, PostageAppService>();
            services.AddScoped<ICommentAppService, CommentAppService>();
            services.AddScoped<ILikesAppService, LikesAppService>();
        }
    }
}

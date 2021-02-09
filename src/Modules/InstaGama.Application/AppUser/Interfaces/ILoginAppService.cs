using InstaGama.Application.AppUser.Output;
using System.Threading.Tasks;

namespace InstaGama.Application.AppUser.Interfaces
{
    public interface ILoginAppService
    {
        Task<UserViewModel> LoginAsync(string login, string password);
    }
}

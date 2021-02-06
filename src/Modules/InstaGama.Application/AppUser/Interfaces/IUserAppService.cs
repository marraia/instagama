using InstaGama.Application.AppUser.Input;
using InstaGama.Application.AppUser.Output;
using System.Threading.Tasks;

namespace InstaGama.Application.AppUser.Interfaces
{
    public interface IUserAppService
    {
        Task<UserViewModel> InsertAsync(UserInput input);
        Task<UserViewModel> GetByIdAsync(int id);
    }
}

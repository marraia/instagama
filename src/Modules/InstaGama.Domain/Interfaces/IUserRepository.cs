using InstaGama.Domain.Entities;
using System.Threading.Tasks;

namespace InstaGama.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<int> InsertAsync(User user);
        Task<User> GetByLoginAsync(string login);
        Task<User> GetByIdAsync(int id);
    }
}

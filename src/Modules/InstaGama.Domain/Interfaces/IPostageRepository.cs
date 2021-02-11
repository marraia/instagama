using InstaGama.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InstaGama.Domain.Interfaces
{
    public interface IPostageRepository
    {
        Task<int> InsertAsync(Postage postage);
        Task<List<Postage>> GetPostageByUserIdAsync(int userId);
    }
}

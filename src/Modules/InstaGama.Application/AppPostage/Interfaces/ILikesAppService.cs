using InstaGama.Domain.Entities;
using System.Threading.Tasks;

namespace InstaGama.Application.AppPostage.Interfaces
{
    public interface ILikesAppService
    {
        Task InsertAsync(int postageId);
        Task<int> GetQuantityOfLikesByPostageIdAsync(int postageId);
    }
}

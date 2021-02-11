using InstaGama.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InstaGama.Domain.Interfaces
{
    public interface ICommentRepository
    {
        Task<int> InsertAsync(Comments comment);
        Task<List<Comments>> GetByPostageIdAsync(int postageId);
    }
}

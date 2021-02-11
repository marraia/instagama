using InstaGama.Application.AppPostage.Input;
using InstaGama.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InstaGama.Application.AppPostage.Interfaces
{
    public interface IPostageAppService
    {
        Task<Postage> InsertAsync(PostageInput input);
        Task<List<Postage>> GetPostageByUserIdAsync();
    }
}

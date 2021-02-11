using InstaGama.Application.AppPostage.Input;
using InstaGama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InstaGama.Application.AppPostage.Interfaces
{
    public interface ICommentAppService
    {
        Task<Comments> InsertAsync(int postageId, CommentInput input);
        Task<List<Comments>> GetByPostageIdAsync(int postageId);
    }
}

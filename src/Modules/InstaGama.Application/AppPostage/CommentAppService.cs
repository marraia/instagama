using InstaGama.Application.AppPostage.Input;
using InstaGama.Application.AppPostage.Interfaces;
using InstaGama.Domain.Core.Interfaces;
using InstaGama.Domain.Entities;
using InstaGama.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InstaGama.Application.AppPostage
{
    public class CommentAppService : ICommentAppService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly ILogged _logged;
        public CommentAppService(ICommentRepository commentRepository,
                                  ILogged logged)
        {
            _commentRepository = commentRepository;
            _logged = logged;
        }
        public async Task<List<Comments>> GetByPostageIdAsync(int postageId)
        {
            var comments = await _commentRepository
                                    .GetByPostageIdAsync(postageId)
                                    .ConfigureAwait(false);

            return comments;
        }

        public async Task<Comments> InsertAsync(int postageId, CommentInput input)
        {
            var userId = _logged.GetUserLoggedId();

            var comment = new Comments(postageId, userId, input.Text);

            //Validar os dados obrigatorios

            var id = await _commentRepository
                              .InsertAsync(comment)
                              .ConfigureAwait(false);

            comment.SetId(id);

            return comment;
        }
    }
}

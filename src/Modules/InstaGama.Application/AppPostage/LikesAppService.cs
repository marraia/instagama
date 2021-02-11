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
    public class LikesAppService : ILikesAppService
    {
        private readonly ILikesRepository _likesRepository;
        private readonly ILogged _logged;

        public LikesAppService(ILikesRepository likesRepository,
                                ILogged logged)
        {
            _likesRepository = likesRepository;
            _logged = logged;
        }

        public async Task<int> GetQuantityOfLikesByPostageIdAsync(int postageId)
        {
            return await _likesRepository
                            .GetQuantityOfLikesByPostageIdAsync(postageId)
                            .ConfigureAwait(false);
        }

        public async Task InsertAsync(int postageId)
        {
            var userId = _logged.GetUserLoggedId();

            var likesExistForPostage = await _likesRepository
                                                .GetByUserIdAndPostageIdAsync(userId, postageId)
                                                .ConfigureAwait(false);
            if (likesExistForPostage != null)
            {
                await _likesRepository
                         .DeleteAsync(likesExistForPostage.Id)
                         .ConfigureAwait(false);
            }

            var like = new Likes(postageId, userId);
            //Validar os dados obriatorios..

            await _likesRepository
                    .InsertAsync(like)
                    .ConfigureAwait(false);
        }
    }
}

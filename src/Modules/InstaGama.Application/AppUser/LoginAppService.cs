using InstaGama.Application.AppUser.Interfaces;
using InstaGama.Application.AppUser.Output;
using InstaGama.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace InstaGama.Application.AppUser
{
    public class LoginAppService : ILoginAppService
    {
        private readonly IUserRepository _userRepository;

        public LoginAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserViewModel> LoginAsync(string login, string password)
        {
            var user = await _userRepository
                                .GetByLoginAsync(login)
                                .ConfigureAwait(false);

            if (user is null)
            {
                throw new Exception("Usuário não encontrado");
            }

            if (!user.IsEqualPassword(password))
            {
                return default;
            }

            return new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Birthday = user.Birthday,
                Email = user.Email,
                Gender = user.Gender,
                Photo = user.Photo
            };
        }
    }
}

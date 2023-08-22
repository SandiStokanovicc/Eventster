using Eventster.Dtos.TokenDtos;

namespace Eventster.Services.AuthService
{
    public interface IAuthService
    {
        Task<Boolean> UserExists(string username);
        Task<Boolean> AddUser(RegisterModel model);
        Task<ServiceResponse<TokenDto>> DoLogin(LoginModel model);
    }
}

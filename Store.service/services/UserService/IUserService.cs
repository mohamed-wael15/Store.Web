using Store.service.services.UserService.Dtos;

namespace Store.service.services.UserService
{
    public interface IUserService
    {
        Task<UserDto> Login(LoginDto input);
        Task<UserDto> Register(RegisterDto input);
    }
}

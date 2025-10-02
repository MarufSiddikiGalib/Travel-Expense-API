using BLL.DTOs;

namespace BLL.Service
{
    public interface IUserService
    {
        bool Register(UserRegistrationDto dto);
    }
}
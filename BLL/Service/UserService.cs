using DAL.Interfaces;
using DAL.EF;
using BLL.DTOs;

namespace BLL.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repo;

        public UserService(IUserRepository repository)
        {
            repo = repository;
        }

        public bool Register(UserRegistrationDto dto)
        {
            // Simple business rule: email must be unique
            var existing = repo.GetByEmail(dto.Email);
            if (existing != null) return false;

            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Role = dto.Role
                // Password hash etc. can be added here
            };

            repo.Add(user);
            return true;
        }
    }
}
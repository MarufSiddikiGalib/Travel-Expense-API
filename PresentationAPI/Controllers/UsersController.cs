using BLL.DTOs;
using BLL.Service;
using PresentationAPI.Models;
using System;
using System.Web.Http;

namespace PresentationAPI.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserService userService;


        public UsersController()
        {

            var dbContext = new DAL.EF.TravelExpenseDbContext();
            var userRepo = new DAL.Repos.UserRepository(dbContext);
            userService = new UserService(userRepo);
        }

        [HttpPost]
        [Route("api/users/register")]
        public IHttpActionResult Register(UserRegistrationModel model)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                var dto = new UserRegistrationDto
                {
                    Name = model.Name,
                    Email = model.Email,
                    Role = model.Role,
                    Password = model.Password
                };

                bool result = userService.Register(dto);

                if (!result)
                    return BadRequest("Email already exists.");

                return Ok("Registration successful.");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
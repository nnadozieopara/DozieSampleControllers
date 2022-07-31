using Microsoft.AspNetCore.Mvc;
using SampleControllers.Interfacess;

namespace SampleControllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public IUserServices userServices { get; }
        public UserController(IUserServices userServices)
        {
            this.userServices = userServices;
        }

        [HttpPost]
        public IActionResult CreateUser(string userName, string password, string email)
        {
            userServices.CreateUser(userName, password, email);
            return Ok("User Created Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            userServices.DeleteUser(id);
            return Ok("User Successfully Deleted");
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(userServices.GetUsers());
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(Guid id)
        {
            return Ok(userServices.GetUser(id));
        }
    }
}

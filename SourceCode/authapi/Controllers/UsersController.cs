using authapi.Data.Repositories;
using authapi.Models;
using authapi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace authapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("SignIn")]
        [AllowAnonymous]
        public ActionResult<LoginResponse> SignIn([FromBody] UserLogin login)
        {
            try
            {
                return Ok(_service.SignIn(login));
            }
            catch (System.Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost("SignUp")]
        [AllowAnonymous]
        public ActionResult SignUp([FromBody] UserSignUp user)
        {
            try
            {
                _service.SignUp(user);
                return Ok();
            }
            catch (System.Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost("Recover")]
        [AllowAnonymous]
        public ActionResult<UserRecoverResponse> Recover([FromQuery] string username)
        {
            try
            {
                return Ok(_service.Recover(username));
            }
            catch (System.Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPut("ChangePassword")]
        [AllowAnonymous]
        public ActionResult ChangePassword([FromBody] Models.UserRecover user)
        {
            try
            {
                _service.ChangePassword(user);
                return Ok();
            }
            catch (System.Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpGet]
        public ActionResult<UserListReduced> Get()
        {
            try
            {
                return Ok(_service.List());
            }
            catch (System.Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<UserList> Get([FromRoute] long id)
        {
            try
            {
                return Ok(_service.Get(id));
            }
            catch (System.Exception e)
            {
                return Problem(e.Message);
            }
        }
    }
}

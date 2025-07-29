using Microsoft.AspNetCore.Mvc;

namespace TestingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public bool Login([FromForm]LoginDetails login)
        {
            return login.Username == "lauren";
        }
    }

    public record LoginDetails(string Username, string Password);
}

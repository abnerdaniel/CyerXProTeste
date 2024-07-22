using CyerXProTeste.Models;
using CyerXProTeste.Services;
using Microsoft.AspNetCore.Mvc;

namespace CyerXProTeste.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {

        [HttpPost]
        [Route("auth")]
        public IActionResult Auth(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                var token =  TokenService.GenerateToken(new Author());
                return Ok(token);
            }
            return BadRequest("Username or password invalid.");
        }
    }
}

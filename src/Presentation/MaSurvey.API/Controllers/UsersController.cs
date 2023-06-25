using MaSurvey.Application.Features.Commands.Users;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MaSurvey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
            
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            CreateUserResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginUserRequest loginUserCommandRequest)
        {
            LoginUserResponse response = await _mediator.Send(loginUserCommandRequest);
            if (response.Message == "Giriş başarılı")
            {
                Response.Cookies.Append(
                    "access_token",
             response.AccessToken.AccesssToken,
            new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7),
                IsEssential = true,
                SameSite = SameSiteMode.None,
                Secure = true,
            });
                return Ok(response);
            }
            else
            {
                return StatusCode((int)HttpStatusCode.NotAcceptable, response);
                //}
                //return Ok(response);
            }
        }
    }
}

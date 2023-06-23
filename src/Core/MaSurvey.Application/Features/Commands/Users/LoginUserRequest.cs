using MaSurvey.Application.Abstractions.Token;
using MaSurvey.Application.DTOs;
using MaSurvey.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MaSurvey.Application.Features.Commands.Users
{
    public class LoginUserRequest : IRequest<LoginUserResponse>
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
    public class LoginUserHandler : IRequestHandler<LoginUserRequest, LoginUserResponse>
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ITokenHandler _tokenHandler;


        public LoginUserHandler(SignInManager<User> signInManager, UserManager<User> userManager, ITokenHandler tokenHandler)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _tokenHandler = tokenHandler;
        }


        public async Task<LoginUserResponse> Handle(LoginUserRequest request, CancellationToken cancellationToken)
        {
            User user = await _userManager.FindByEmailAsync(request.UserNameOrEmail);
            if (user == null)
            {
                user = await _userManager.FindByNameAsync(request.UserNameOrEmail);
            }

            SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (result.Succeeded)
            {
                Token token = _tokenHandler.CreateAccess(10, user.Id.ToString());
                return new()
                {
                    AccessToken = token,
                    Message = "Giriş başarılı"
                };

            }
            return new()
            {
                Message = "Kullanıcı adı veya şifre hatalı!"
            };
        }
    }
    public class LoginUserResponse
    {
        public Token AccessToken { get; set; }
        public string Message { get; set; }
    }
}

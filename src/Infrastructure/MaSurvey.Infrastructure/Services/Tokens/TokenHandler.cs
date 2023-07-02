using MaSurvey.Application.Abstractions.Token;
using MaSurvey.Application.DTOs;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MaSurvey.Infrastructure.Services.Tokens
{
    public class TokenHandler : ITokenHandler
    {
        readonly IConfiguration _configuration;
        public TokenHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Token CreateAccess(int minute,string userId)
        {
            Token token = new();
            //security key için simertrik alıyoruz
            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]));
            //şifrelenmiş kimlik oluşturuyoruz
            SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha256);
            //oluşturalacak token ayarlarını veriyoruz.
            token.Expiration = DateTime.Now.AddMinutes(minute);
            JwtSecurityToken securityToken = new(
                audience: _configuration["Token:Audience"],
                issuer: _configuration["Token:Issuer"],
                expires: token.Expiration.AddHours(72),
                notBefore: DateTime.Now,
                signingCredentials: signingCredentials,
                
                claims: new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub,userId)
                }             
                );
            //token oluşturucu sınıfından örnek alıyoruz.
            JwtSecurityTokenHandler tokenHandler = new();
            token.AccesssToken = tokenHandler.WriteToken(securityToken);
            return token;
        }
    }
}

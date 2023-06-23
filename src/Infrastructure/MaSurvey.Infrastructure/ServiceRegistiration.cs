using IdentityServer4.Models;
using MaSurvey.Application.Abstractions.Token;
using Microsoft.Extensions.DependencyInjection;
using MaSurvey.Infrastructure.Services.Tokens;

namespace MaSurvey.Infrastructure
{
    public static class ServiceRegistiration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenHandler,TokenHandler>();
           
        }
    }

    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
        {
            new ApiResource("your_api_name", "Your API")
        };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
        {
            new Client
            {
                ClientId = "api-swagger",
                RequireClientSecret = false,
                AllowedGrantTypes = GrantTypes.Code,
                RequirePkce = true,
                RedirectUris = { "https://localhost:7075/swagger/index.html" },
                AllowedCorsOrigins = { "https://localhost:7075" },
                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "api" }
            }
        };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };
        }
    }
}

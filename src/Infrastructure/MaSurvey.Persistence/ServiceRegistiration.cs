using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MaSurvey.Persistence.Context;
using MaSurvey.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MaSurvey.Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<MaSurveyDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddIdentityCore<User>(options =>
                                              options.SignIn.RequireConfirmedAccount = true)
                                              .AddEntityFrameworkStores<MaSurveyDbContext>();


            services.AddScoped<IOptionRepository, OptionRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<ISurveyRepository, SurveyRepository>();
            services.AddScoped<IResponseRepository, ResponseRepository>();
        }
    }



    public static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager cfg = new ConfigurationManager();
                cfg.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/MaSurvey.API"));
                cfg.AddJsonFile("appsettings.json");//microsoft.extensions.configuration.json adındaki paket üst 2 satır için gerekli. çok gerekli

                return cfg.GetConnectionString("DefaultConnection");
            }
        }
    }
}

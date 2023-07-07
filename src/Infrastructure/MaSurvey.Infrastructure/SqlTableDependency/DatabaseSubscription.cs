using MaSurvey.Infrastructure.Hubs;
using MaSurvey.Application.DTOs;
using MaSurvey.Domain.Entities;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using TableDependency.SqlClient;

namespace MaSurvey.Infrastructure.SqlTableDependency
{
    public interface IDatabaseSubscription
    {
        void Configure(string tableName);
    }
    public class DatabaseSubscription<T> : IDatabaseSubscription where T : class, new()
    {
        SqlTableDependency<T> _tableDependency;
        IConfiguration _configuration;
        IHubContext<OptionHub> _hubContext;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        

        public DatabaseSubscription(IConfiguration configuration, IHubContext<OptionHub> hubContext, IServiceScopeFactory serviceScopeFactory)
        {
            _configuration = configuration;
            _hubContext = hubContext;
            _serviceScopeFactory = serviceScopeFactory;            
        }

        public void Configure(string tableName)
        {
            _tableDependency = new SqlTableDependency<T>(_configuration.GetConnectionString("DefaultConnection"), tableName);
            _tableDependency.OnChanged += async (o, e) =>
            {
                List<AnsweredOption> datas;
                T dataBack = new T();
                //UserManager<AppUser> _userManager;
                AnsweredOption option = null;
                //AppUser user = null;
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    // _userManager = scope.ServiceProvider.GetService<UserManager<AppUser>>();
                    dataBack = e.Entity;

                     option = (AnsweredOption)Convert.ChangeType(dataBack, typeof(Option));
                    // user = await _userManager.FindByIdAsync(option.UserId.ToString());
                }               

                AnsweredOptionDTO dto = new AnsweredOptionDTO
                {
                    OptionContent= option.OptionContent,
                };

                string jsonData = JsonSerializer.Serialize(dto);
                await _hubContext.Clients.All.SendAsync("receiveMessage", jsonData);


            };
            _tableDependency.OnError += (o, e) =>
            {

            };
            _tableDependency.Start();
        }

        ~DatabaseSubscription()
        {
            _tableDependency.Stop();
        }
    }
}

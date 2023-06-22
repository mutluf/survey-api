
using Microsoft.AspNetCore.SignalR;


namespace MaSurvey.Infrastructure.Hubs
{
    public class OptionHub: Hub
    {
        public async Task SendMessageAsync()
        {
          
            //await Clients.All.SendAsync("receiveMessage", "hello");
        }
    }
}

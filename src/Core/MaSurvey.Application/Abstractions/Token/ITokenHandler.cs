namespace MaSurvey.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        DTOs.Token CreateAccess(int minute, string userId);
    }
}

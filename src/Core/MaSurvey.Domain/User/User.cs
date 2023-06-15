using Microsoft.AspNetCore.Identity;

namespace MaSurvey.Domain.Entities;

public class User : IdentityUser<int>
{
   
    public string? Surname { get; set; }
    public string? Name { get; set; }
   
}


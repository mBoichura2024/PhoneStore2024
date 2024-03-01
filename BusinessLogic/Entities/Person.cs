using Microsoft.AspNetCore.Identity;

namespace Core.Entities
{
    public class Person : IdentityUser
    {
        public string Surname { get; set; }
    }
}
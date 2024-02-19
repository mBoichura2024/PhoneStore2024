using Microsoft.AspNetCore.Identity;

namespace DataAccess.Entities
{
    public class Person : IdentityUser
    {
        public string Surname { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;

namespace Core.Entities
{
    public class Person : IdentityUser
    {
#pragma warning disable CS8618 // Non-nullable property 'Surname' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Surname { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Surname' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}
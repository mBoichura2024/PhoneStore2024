namespace Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Name { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

        //Navigation Properties
        public ICollection<Phone> Phones { get; set; } = new HashSet<Phone>();
    }
}
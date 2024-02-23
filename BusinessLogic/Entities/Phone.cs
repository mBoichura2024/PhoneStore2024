namespace Core.Entities
{
    public class Phone
    {
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Name { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public int CategoryId { get; set; }
        public int Price { get; set; }

        //Navigation Properties
#pragma warning disable CS8618 // Non-nullable property 'Category' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public Category Category { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Category' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}
namespace Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Properties
        public ICollection<Phone> Phones { get; set; } = new HashSet<Phone>();
    }
}
namespace MVC_Store.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }

        //Navigation Properties
        public Category Category { get; set; }
    }
}
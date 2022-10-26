namespace Friont_To_Back.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string?  Title { get; set; }
        public string? ImgUrl { get; set; }
    }
}

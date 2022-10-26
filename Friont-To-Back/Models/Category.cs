namespace Friont_To_Back.Models
{
    public class Category:BaseClass
    {
        public string? Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}

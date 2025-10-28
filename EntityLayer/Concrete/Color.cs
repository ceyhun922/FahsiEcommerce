using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        public string? ColorName { get; set; }
        public bool ColorStatus { get; set; }
        public List<Product>? Products { get; set; }
    }
}
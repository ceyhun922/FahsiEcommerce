using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        public string? SizeName { get; set; }
        public bool SizeStatus { get; set; }
        public List<Product>? Products { get; set; }
    }
}
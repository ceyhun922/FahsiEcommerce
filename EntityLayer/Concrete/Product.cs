using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int ProductTitle{ get; set; }
        public int ProductPrice{ get; set; }
        public int ProductStock{ get; set; }
        public bool ProductStatus { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int SizeId { get; set; }
        public Size? Size { get; set; }
        public int ColorId { get; set; }
        public Color? Color { get; set; }
    }

}
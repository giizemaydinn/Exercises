using System.Drawing;

namespace Challenge16Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public Image? Image { get; set; }

    }
}

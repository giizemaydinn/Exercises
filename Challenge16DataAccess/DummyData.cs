using Challenge16Entities;

namespace Challenge16DataAccess
{
    public static class DummyData
    {
        public static List<Product> Products = new List<Product>();
        public static List<Category> Categories = new List<Category>();
        //public static List<IEntity> Entities = new List<IEntity>();

        public static void FillSet()
        {
            for (int i = 0; i < 5; i++)
            {
                Categories.Add(new Category { Id = i, CategoryName = "Category" + i });

                for (int j = 0; j < 10; j++)
                {
                    Products.Add(new Product { Id = i * 10 + j, CategoryId = i, Price = i * j + 100, ProductName = "Product" + j, UnitsInStock = j });
                }
            }
        }

    }
}

using Challenge12.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Challenge12.DataAccess
{
    public class ProductDal : BaseRepository<Product>
    {
        public List<ProductDto> GetAllDto()
        {
            using (var context = new NorthwindContext())
            {
                try
                {
                    var query = (from product in context.Products
                                 join category in context.Categories on product.CategoryID equals category.CategoryID
                                 join supplier in context.Suppliers on product.SupplierID equals supplier.SupplierID

                                 where context.Products.Count() > 0

                                 select new ProductDto
                                 {
                                     ProductID = product.ProductID,
                                     ProductName= product.ProductName,
                                     CompanyNameOfSupplier=supplier.CompanyName,
                                     CategoryName= category.CategoryName,
                                     QuantityPerUnit= product.QuantityPerUnit,
                                     UnitPrice= product.UnitPrice,
                                     UnitsInStock= product.UnitsInStock,
                                     ReorderLevel= product.ReorderLevel,
                                     Discontinued= product.Discontinued
                                 }).ToList();
                    return query.ToList();
                }
                catch (System.Exception)
                {

                    throw;
                }

            }
        }
    }


}

using Challenge16Business.Abstract;
using Challenge16Business.Responses;
using Challenge16DataAccess;
using Challenge16Entities;

namespace Challenge16Business.Concrete
{
    public class ProductService : IProductService
    {
        ProductDal productDal = new ProductDal();

        public async Task<IResponse> Add(Product product)
        {
            bool result = await productDal.Add(product);

            if (result)
            {
                return new Response(true, Messages.ProductAdd, 200);

            }

            return new Response(false, Messages.ProductFailedAdd, 400);

        }

        public async Task<IResponse> Delete(int id)
        {
            bool result = await productDal.Delete(id);

            if (result)
            {
                return new Response(true, Messages.ProductDelete, 200);

            }

            return new Response(false, Messages.ProductFailedDelete, 400);
        }

        public async Task<IDataResponse<List<Product>>> GetAll()
        {
            List<Product> result = await productDal.GetAll();

            if (result != null)
            {
                return new DataResponse<List<Product>>(result, true, Messages.ProductGetAll, 200);

            }

            return new DataResponse<List<Product>>(result, false, Messages.ProductFailedGetAll, 400);
        }

        public async Task<IDataResponse<Product>> GetById(int id)
        {
            Product result = await productDal.GetById(x => x.Id == id);

            if (result != null)
            {
                return new DataResponse<Product>(result, true, Messages.ProductGetById, 200);

            }

            return new DataResponse<Product>(result, false, Messages.ProductFailedGetById, 400);
        }

        public async Task<IResponse> Update(Product product)
        {
            bool result = await productDal.Update(product);

            if (result)
            {
                return new Response(true, Messages.ProductUpdate, 200);

            }

            return new Response(false, Messages.ProductFailedUpdate, 400);
        }
    }
}

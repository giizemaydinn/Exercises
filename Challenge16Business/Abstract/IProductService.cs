using Challenge16Business.Responses;
using Challenge16Entities;

namespace Challenge16Business.Abstract
{
    public interface IProductService
    {
        Task<IDataResponse<Product>> GetById(int id);
        Task<IDataResponse<List<Product>>> GetAll();
        Task<IResponse> Add(Product product);
        Task<IResponse> Delete(int id);
        Task<IResponse> Update(Product product);
    }
}

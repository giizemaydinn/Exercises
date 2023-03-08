using Challenge16Business.Responses;
using Challenge16Entities;

namespace Challenge16Business.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResponse<Category>> GetById(int id);
        Task<IDataResponse<List<Category>>> GetAll();
        Task<IResponse> Add(Category category);
        Task<IResponse> Delete(int id);
        Task<IResponse> Update(Category category);
    }
}

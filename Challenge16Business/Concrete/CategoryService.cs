using Challenge16Business.Abstract;
using Challenge16Business.Responses;
using Challenge16DataAccess;
using Challenge16Entities;

namespace Challenge16Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        CategoryDal categoryDal = new CategoryDal();
        public async Task<IResponse> Add(Category category)
        {
            bool result = await categoryDal.Add(category);

            if (result)
            {
                return new Response(true, Messages.CategoryAdd, 200);

            }

            return new Response(false, Messages.CategoryFailedAdd, 400);

        }

        public async Task<IResponse> Delete(int id)
        {
            bool result = await categoryDal.Delete(id);

            if (result)
            {
                return new Response(true, Messages.CategoryDelete, 200);

            }

            return new Response(false, Messages.CategoryFailedDelete, 400);
        }

        public async Task<IDataResponse<List<Category>>> GetAll()
        {
            List<Category> result = await categoryDal.GetAll();

            if (result != null)
            {
                return new DataResponse<List<Category>>(result, true, Messages.CategoryGetAll, 200);

            }

            return new DataResponse<List<Category>>(result, false, Messages.CategoryFailedGetAll, 400);
        }

        public async Task<IDataResponse<Category>> GetById(int id)
        {
            Category result = await categoryDal.GetById(x => x.Id == id);

            if (result != null)
            {
                return new DataResponse<Category>(result, true, Messages.CategoryGetById, 200);

            }

            return new DataResponse<Category>(result, false, Messages.CategoryFailedGetById, 400);
        }

        public async Task<IResponse> Update(Category category)
        {
            bool result = await categoryDal.Update(category);

            if (result)
            {
                return new Response(true, Messages.CategoryUpdate, 200);

            }

            return new Response(false, Messages.CategoryFailedUpdate, 400);
        }
    }
}

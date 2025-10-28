using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using ServiceLayer.Abstract;

namespace ServiceLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void DeleteService(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public Category GetFindIdService(Expression<Func<Category, bool>> expression)
        {
            return _categoryDal.GetFindId(expression);
        }

        public void InsertService(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public List<Category> ListAllService()
        {
            return _categoryDal.ListAll();
        }

        public List<Category> ListAllServiceFilter(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.ListAll(filter);
        }

        public void UpdateService(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
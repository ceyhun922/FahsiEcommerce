using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using ServiceLayer.Abstract;

namespace ServiceLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void DeleteService(Product entity)
        {
            _productDAL.Delete(entity);
        }

        public Product GetFindIdService(Expression<Func<Product, bool>> expression)
        {
            return _productDAL.GetFindId(expression);
        }

        public void InsertService(Product entity)
        {
            _productDAL.Insert(entity);
        }

        public List<Product> ListAllService()
        {
            return _productDAL.ListAll();
        }

        public List<Product> ListAllServiceFilter(Expression<Func<Product, bool>> filter)
        {
            return _productDAL.ListAll(filter);
        }


        public void UpdateService(Product entity)
        {
            _productDAL.Update(entity);
        }
    }
}
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Entityframework
{
    public class EFCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        public EFCategoryRepository(FashiDbContext context) : base(context)
        {
        }
    }
}
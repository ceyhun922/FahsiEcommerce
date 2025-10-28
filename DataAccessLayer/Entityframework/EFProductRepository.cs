using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Entityframework
{
    public class EFProductRepository : GenericRepository<Product>, IProductDAL
    {
        public EFProductRepository(FashiDbContext context) : base(context)
        {
        }
    }
}
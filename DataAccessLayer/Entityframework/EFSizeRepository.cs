using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Entityframework
{
    public class EFSizeRepository : GenericRepository<Size>, ISizeDAL
    {
        public EFSizeRepository(FashiDbContext context) : base(context)
        {
        }
    }
}
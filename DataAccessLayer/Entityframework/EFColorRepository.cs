
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Entityframework
{
    public class EFColorRepository : GenericRepository<Color>, IColorDAL
    {
        public EFColorRepository(FashiDbContext context) : base(context)
        {
        }
    }
}
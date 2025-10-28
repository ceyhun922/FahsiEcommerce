using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using ServiceLayer.Abstract;

namespace ServiceLayer.Concrete
{
    public class SizeManager : ISizeService
    {
        private readonly ISizeDAL _sizeDAL;

        public SizeManager(ISizeDAL sizeDAL)
        {
            _sizeDAL = sizeDAL;
        }

        public void DeleteService(Size entity)
        {
           _sizeDAL.Delete(entity);
        }

        public Size GetFindIdService(Expression<Func<Size, bool>> expression)
        {
            return _sizeDAL.GetFindId(expression);
        }

        public void InsertService(Size entity)
        {
            _sizeDAL.Insert(entity);
        }

        public List<Size> ListAllService()
        {
            return _sizeDAL.ListAll();
        }

        public List<Size> ListAllServiceFilter(Expression<Func<Size, bool>> filter)
        {
            return _sizeDAL.ListAll(filter);
        }

        public void UpdateService(Size entity)
        {
            _sizeDAL.Update(entity);
        }
    }
}
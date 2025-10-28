using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using ServiceLayer.Abstract;

namespace ServiceLayer.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDAL _colorDAL;

        public ColorManager(IColorDAL colorDAL)
        {
            _colorDAL = colorDAL;
        }

        public void DeleteService(Color entity)
        {
            _colorDAL.Delete(entity);
        }

        public Color GetFindIdService(Expression<Func<Color, bool>> expression)
        {
            return _colorDAL.GetFindId(expression);
        }

        public void InsertService(Color entity)
        {
            _colorDAL.Insert(entity);
        }

        public List<Color> ListAllService()
        {
            return _colorDAL.ListAll();
        }

        public List<Color> ListAllServiceFilter(Expression<Func<Color, bool>> filter)
        {
            return _colorDAL.ListAll(filter);
        }

        public void UpdateService(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
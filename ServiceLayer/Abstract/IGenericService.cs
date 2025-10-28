using System.Linq.Expressions;

namespace ServiceLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> ListAllService();
        List<T> ListAllServiceFilter(Expression<Func<T, bool>> filter);
        T GetFindIdService(Expression<Func<T, bool>> expression);
        void InsertService(T entity);
        void UpdateService(T entity);
        void DeleteService(T entity);
    }
}

using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T>
    {
        List<T> ListAll();
        List<T> ListAll(Expression<Func<T, bool>> filter);
        T GetFindId(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
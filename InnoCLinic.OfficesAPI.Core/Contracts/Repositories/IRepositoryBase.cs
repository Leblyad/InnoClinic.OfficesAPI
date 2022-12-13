using System.Linq.Expressions;

namespace InnoCLinic.OfficesAPI.Core.Contracts.Repositories
{
    public interface IRepositoryBase<T>
    {
        Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(Expression<Func<T, bool>> expression);
    }
}

using Application.Domain.Models.Response;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<RepoResponse> CreateAsync(TEntity entity);
        Task<RepoResponse> DeleteAsync(TEntity entity);
        Task<RepoResponse> ExistsAsync(Expression<Func<TEntity, bool>> predicate);
        Task<RepoResponse<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<RepoResponse> UpdateAsync(TEntity entity);
    }
}
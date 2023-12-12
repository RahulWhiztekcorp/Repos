using DapperCoreAPI.Models;

namespace DapperCoreAPI.Repository.Interface
{
    public interface IBranchRepository
    {
        Task<IEnumerable<Branch>> GetAllAsync();
        Task<Branch> GetByIdAsync(long id);
        Task Create(Branch _Branch);
        Task Update(Branch _Branch);
        Task Delete(long id);
    }
}

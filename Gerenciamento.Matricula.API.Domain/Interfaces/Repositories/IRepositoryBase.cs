using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<Tentity> where Tentity : class
    {
        Task DeleteAllAsync();
        Task DeleteAsync(int id);
        Task CreateAsync(Tentity entity);
        Task UpdateAsync(Tentity entity);
        Task<IList<Tentity>> GetAllAsync();
        Task<Tentity> GetAsync(string name);
    }
}

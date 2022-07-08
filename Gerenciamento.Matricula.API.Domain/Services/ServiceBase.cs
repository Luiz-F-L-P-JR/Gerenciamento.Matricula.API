using Gerenciamento.Matricula.API.Domain.Interfaces.Repositories;
using Gerenciamento.Matricula.API.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Domain.Services
{
    public class ServiceBase<Tentity> : IServiceBase<Tentity> where Tentity : class
    {
        private readonly IRepositoryBase<Tentity> _repositoryBase;

        public ServiceBase(IRepositoryBase<Tentity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public async Task CreateAsync(Tentity entity)
        {
            await _repositoryBase.CreateAsync(entity);
        }

        public async Task<Tentity> GetAsync(string name)
        {
            return await _repositoryBase.GetAsync(name);
        }

        public async Task<IList<Tentity>> GetAllAsync()
        {
            return await _repositoryBase.GetAllAsync();
        }

        public async Task UpdateAsync(Tentity entity)
        {
            await _repositoryBase.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repositoryBase.DeleteAsync(id);
        }

        public async Task DeleteAllAsync()
        {
            await _repositoryBase.DeleteAllAsync();
        }
    }
}

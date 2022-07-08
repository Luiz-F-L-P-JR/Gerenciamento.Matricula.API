using Gerenciamento.Matricula.API.Application.Interfaces.Services;
using Gerenciamento.Matricula.API.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Application.Services
{
    public class AppServiceBase<Tentity> : IAppServiceBase<Tentity> where Tentity : class
    {
        private readonly IServiceBase<Tentity> _serviceBase;

        public AppServiceBase(IServiceBase<Tentity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public async Task CreateAsync(Tentity entity)
        {
            await _serviceBase.CreateAsync(entity);
        }

        public async Task<Tentity> GetAsync(string name)
        {
            return await _serviceBase.GetAsync(name);
        }

        public async Task<IList<Tentity>> GetAllAsync()
        {
            return await _serviceBase.GetAllAsync();
        }

        public async Task UpdateAsync(Tentity entity)
        {
            await _serviceBase.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _serviceBase.DeleteAsync(id);
        }

        public async Task DeleteAllAsync()
        {
            await _serviceBase.DeleteAllAsync();
        }
    }
}

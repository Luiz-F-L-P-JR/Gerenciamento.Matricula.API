using Dapper;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using Gerenciamento.Matricula.API.Domain.Interfaces.Repositories;

namespace Gerenciamento.Matricula.API.Data.Repositories
{
    public class RepositoryBase<Tentity> : IRepositoryBase<Tentity> where Tentity : class
    {
        private SqlConnection Con;
        private string Connection = "Data Source=desafiophidelis.database.windows.net;Initial Catalog=MATRICULADB; User Id=Desafiophidelis; Password=Des@fio01";

        public RepositoryBase()
        {

        }

        #region Região do Aluno

        public async Task CreateAsync(Tentity entity)
        {
            using (Con = new SqlConnection(Connection))
            {
                await Con.OpenAsync();

                var query = $@"Insert into Aluno (NomeCompleto, DataDaMatricula) values (@nomeCompleto, @DataDaMatricula)";

                await Con.ExecuteAsync(query, entity);

                await Con.CloseAsync();
            }
        }

        public async Task<Tentity> GetAsync(string name)
        {
            Tentity entidade;

            using (Con = new SqlConnection(Connection))
            {
                await Con.OpenAsync();

                var query = $"Select * from Aluno where NomeCompleto like '{name}%'";

                entidade = await Con.QueryFirstOrDefaultAsync<Tentity>(query);

                await Con.CloseAsync();
            }

            return entidade;
        }

        public async Task<IList<Tentity>> GetAllAsync()
        {

            List<Tentity> listaEntidade = new List<Tentity>();

            using (Con = new SqlConnection(Connection))
            {
                await Con.OpenAsync();

                var query = $"Select * from Aluno order by DataDaMatricula desc";

                var lista = await Con.QueryAsync<Tentity>(query);

                await Con.CloseAsync();
                    
                listaEntidade = lista.ToList();
            }

            return listaEntidade;
        }

        public async Task UpdateAsync(Tentity entity)
        {
            using (Con = new SqlConnection(Connection))
            {
                await Con.OpenAsync();

                var query = $@"Update Aluno Set NomeCompleto = @nomeCompleto, DataDaMatricula = @DataDaMatricula Where Id = @id";

                await Con.ExecuteAsync(query, entity);

                await Con.CloseAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (Con = new SqlConnection(Connection))
            {
                await Con.OpenAsync();

                var query = $"Delete From Aluno Where Id = {id}";

                await Con.ExecuteAsync(query);

                await Con.CloseAsync();
            }
        }

        public async Task DeleteAllAsync()
        {
            using (Con = new SqlConnection(Connection))
            {
                await Con.OpenAsync();

                var query = $"Delete From Aluno";

                await Con.ExecuteAsync(query);

                await Con.CloseAsync();
            }
        }

        #endregion

        #region Região Timer

        public async Task CreateTimerAsync(int time)
        {
            using (Con = new SqlConnection(Connection))
            {
                await Con.OpenAsync();

                var query = $@"Insert into Timer (Time) values ({time})";

                await Con.ExecuteAsync(query);

                await Con.CloseAsync();
            }
        }

        public async Task<int> GetTimerAsync()
        {
            int time;

            using (Con = new SqlConnection(Connection))
            {
                await Con.OpenAsync();

                var query = $"Select Time from Timer";

                time = await Con.QueryFirstOrDefaultAsync<int>(query);

                await Con.CloseAsync();
            }

            return time;
        }

        public async Task UpdateTimerAsync(int time)
        {
            using (Con = new SqlConnection(Connection))
            {
                await Con.OpenAsync();

                var query = $@"Update Timer Set Time = {time}";

                await Con.ExecuteAsync(query);

                await Con.CloseAsync();
            }
        }

        #endregion
    }
}

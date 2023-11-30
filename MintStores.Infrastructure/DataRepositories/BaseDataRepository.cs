using System.Data.SqlClient;
using System.Data;
using MintStores.Core;
using Microsoft.Extensions.Configuration;

namespace MintStores.Infrastructure.DataRepositories
{
    public abstract class BaseDataRepository<T> : IBaseDataRepository<T>
    {
        private readonly IConfiguration _configuration;

        protected BaseDataRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected IDbConnection GetConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public abstract IEnumerable<T> GetAllItems();

        public abstract T GetItemById(int id);

        public abstract bool CreateItem(T newItem);

        public abstract bool UpdateItem(int id, T updatedItem);

        public abstract bool DeleteItem(int id);

        public abstract T GetLastItem();
    }
}

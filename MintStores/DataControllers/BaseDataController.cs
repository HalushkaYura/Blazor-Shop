using MintStores.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace MintStores.DataControllers
{
    public abstract class BaseDataController<T> : IDataController<T>
    {
        private readonly IConfiguration _configuration;

        protected BaseDataController(IConfiguration configuration)
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

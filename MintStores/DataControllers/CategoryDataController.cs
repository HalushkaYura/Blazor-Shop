using MintStores.Interfaces;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using MintStores.Constants;
using MintStores.Models;

namespace MintStores.DataControllers
{
    public class CategoryDataController : IDataController
    {
        private readonly string _connectionString;

        public CategoryDataController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public bool CreateItem<T>(T newItem)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem<T>(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllItems<T>()
        {
            throw new NotImplementedException();
        }

        public T GetItemById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public T UpdateItem<T>(int id, T updatedItem)
        {
            throw new NotImplementedException();
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }


    }
}

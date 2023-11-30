using Dapper;
using Microsoft.Extensions.Configuration;
using MintStores.Constants;
using MintStores.Core.Model;
using System.Data;

namespace MintStores.Infrastructure.DataRepositories
{
    public class StoreDataRepository : BaseDataRepository<Store>
    {
        public StoreDataRepository(IConfiguration configuration) : base(configuration) { }

        public override IEnumerable<Store> GetAllItems()
        {
            using var connection = GetConnection();
            connection.Open();
            return connection.Query<Store>(DataBaseConstants.GetAllStores, commandType: CommandType.StoredProcedure);
        }

        public override Store GetItemById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new { StoreId = id };
            return connection.QueryFirstOrDefault<Store>(DataBaseConstants.GetStoreById, parameters, commandType: CommandType.StoredProcedure);
        }

        public override bool CreateItem(Store newItem)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new
            {
                newItem.StoreName,
                newItem.Phone,
                newItem.Email,
                newItem.Street,
                newItem.City,
                newItem.State,
                newItem.ZipCode
            };

            var rows = connection.Execute(DataBaseConstants.CreateStore, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool UpdateItem(int id, Store updatedItem)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new
            {
                updatedItem.StoreId,
                updatedItem.StoreName,
                updatedItem.Phone,
                updatedItem.Email,
                updatedItem.Street,
                updatedItem.City,
                updatedItem.State,
                updatedItem.ZipCode
            };

            var rows = connection.Execute(DataBaseConstants.UpdateStore, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool DeleteItem(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new { StoreId = id };
            var rows = connection.Execute(DataBaseConstants.DeleteStore, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override Store GetLastItem()
        {
            using var connection = GetConnection();
            connection.Open();
            return connection.QueryFirstOrDefault<Store>(DataBaseConstants.GetLastStore, commandType: CommandType.StoredProcedure);
        }
    }
}

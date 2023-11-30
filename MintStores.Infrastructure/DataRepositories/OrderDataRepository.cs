using Dapper;
using Microsoft.Extensions.Configuration;
using MintStores.Constants;
using MintStores.Core.Model;
using System.Data;

namespace MintStores.Infrastructure.DataRepositories
{
    public class OrderDataRepository : BaseDataRepository<Order>
    {
        public OrderDataRepository(IConfiguration configuration) : base(configuration) { }

        public override IEnumerable<Order> GetAllItems()
        {
            using var connection = GetConnection();
            connection.Open();
            return connection.Query<Order>(DataBaseConstants.GetAllOrders, commandType: CommandType.StoredProcedure);
        }

        public override Order GetItemById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new { OrderId = id };
            return connection.QueryFirstOrDefault<Order>(DataBaseConstants.GetOrderById, parameters, commandType: CommandType.StoredProcedure);
        }

        public override bool CreateItem(Order newItem)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new
            {
                newItem.CustomerId,
                newItem.OrderStatus,
                newItem.OrderDate,
                newItem.RequiredDate,
                newItem.ShippedDate,
                newItem.StoreId,
                newItem.StaffId
            };

            var rows = connection.Execute(DataBaseConstants.CreateOrder, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool UpdateItem(int id, Order updatedItem)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new
            {
                updatedItem.OrderId,
                updatedItem.CustomerId,
                updatedItem.OrderStatus,
                updatedItem.OrderDate,
                updatedItem.RequiredDate,
                updatedItem.ShippedDate,
                updatedItem.StoreId,
                updatedItem.StaffId
            };

            var rows = connection.Execute(DataBaseConstants.UpdateOrder, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool DeleteItem(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new { OrderId = id };
            var rows = connection.Execute(DataBaseConstants.DeleteOrder, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override Order GetLastItem()
        {
            using var connection = GetConnection();
            connection.Open();
            return connection.QueryFirstOrDefault<Order>(DataBaseConstants.GetLastOrder, commandType: CommandType.StoredProcedure);
        }
    }
}

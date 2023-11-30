using Dapper;
using Microsoft.Extensions.Configuration;
using MintStores.Constants;
using MintStores.Core.Model;
using System.Data;

namespace MintStores.Infrastructure.DataRepositories
{
    public class OrderItemDataRepository : BaseDataRepository<OrderItem>
    {
        public OrderItemDataRepository(IConfiguration configuration) : base(configuration) { }

        public override IEnumerable<OrderItem> GetAllItems()
        {
            using var connection = GetConnection();
            connection.Open();
            return connection.Query<OrderItem>(DataBaseConstants.GetAllOrderItems, commandType: CommandType.StoredProcedure);
        }

        public override OrderItem GetItemById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new { OrderId = id };
            return connection.QueryFirstOrDefault<OrderItem>(DataBaseConstants.GetOrderItemById, parameters, commandType: CommandType.StoredProcedure);
        }

        public override bool CreateItem(OrderItem newItem)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new
            {
                newItem.OrderId,
                newItem.ItemId,
                newItem.ProductId,
                newItem.Quantity,
                newItem.Price,
                newItem.Discount
            };

            var rows = connection.Execute(DataBaseConstants.CreateOrderItem, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool UpdateItem(int id, OrderItem updatedItem)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new
            {
                updatedItem.ProductId,
                updatedItem.Quantity,
                updatedItem.Price,
                updatedItem.Discount
            };

            var rows = connection.Execute(DataBaseConstants.UpdateOrderItem, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override bool DeleteItem(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var parameters = new { OrderId = id };
            var rows = connection.Execute(DataBaseConstants.DeleteOrderItem, parameters, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public override OrderItem GetLastItem()
        {
            using var connection = GetConnection();
            connection.Open();
            return connection.QueryFirstOrDefault<OrderItem>(DataBaseConstants.GetLastOrderItem, commandType: CommandType.StoredProcedure);
        }
    }
}

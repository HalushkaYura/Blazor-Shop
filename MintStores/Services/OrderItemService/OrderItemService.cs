using MintStores.Models;

namespace MintStores.Services.OrderItemService
{
    public class OrderItemService : IBaseService<OrderItem>, IOrderItemService
    {
        public OrderItem CreateItem(OrderItem newItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderItem> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public OrderItem GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public OrderItem UpdateItem(int id, OrderItem updateItem)
        {
            throw new NotImplementedException();
        }
    }
}

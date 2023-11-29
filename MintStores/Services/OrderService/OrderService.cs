using MintStores.Models;

namespace MintStores.Services.OrderService
{
    public class OrderService : IBaseService<Order>, IOrderService
    {
        public Order CreateItem(Order newItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Order GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Order UpdateItem(int id, Order updateItem)
        {
            throw new NotImplementedException();
        }
    }
}

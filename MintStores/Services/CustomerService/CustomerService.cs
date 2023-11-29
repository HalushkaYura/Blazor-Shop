using MintStores.Models;

namespace MintStores.Services.CustomerService
{
    public class CustomerService : IBaseService<Customer>, ICustomerService
    {
        public Customer CreateItem(Customer newItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Customer GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer UpdateItem(int id, Customer updateItem)
        {
            throw new NotImplementedException();
        }
    }
}

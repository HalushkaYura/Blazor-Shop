using MintStores.Models;

namespace MintStores.Services.ProductService
{
    public class ProductService : IBaseService<Product>, IProductService
    {
        public Product CreateItem(Product newItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Product GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Product UpdateItem(int id, Product updateItem)
        {
            throw new NotImplementedException();
        }
    }
}

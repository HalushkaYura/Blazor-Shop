using MintStores.Models;

namespace MintStores.Interfaces.DataController
{
    public interface IProductDataController
    {
        IEnumerable<Product> GetProductsByCategory(int categoryId);
    }
}

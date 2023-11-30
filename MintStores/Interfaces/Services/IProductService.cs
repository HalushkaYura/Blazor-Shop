using MintStores.Models;

namespace MintStores.Interfaces.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProductsByCategory(int categoryId);
    }
}

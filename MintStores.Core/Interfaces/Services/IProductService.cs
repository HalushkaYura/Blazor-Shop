using MintStores.Core.Model;

namespace MintStores.Core.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProductsByCategory(int categoryId);
    }
}

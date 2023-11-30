using MintStores.Core.Model;

namespace MintStores.Core.Interfaces.DataRepositories
{
    public interface IProductDataRepository
    {
        IEnumerable<Product> GetProductsByCategory(int categoryId);
    }
}

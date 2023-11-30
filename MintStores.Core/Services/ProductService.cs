using MintStores.Core.Interfaces.DataRepositories;
using MintStores.Core.Model;
using MintStores.Core.Services;

namespace MintStores.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductDataRepository _dataController;
        public ProductService(IProductDataRepository dataController)
        {
            _dataController = dataController;

        }
        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            return _dataController.GetProductsByCategory(categoryId);
        }
    }
}

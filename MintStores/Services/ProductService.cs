using MintStores.DataControllers;
using MintStores.Interfaces;
using MintStores.Interfaces.DataController;
using MintStores.Interfaces.Services;
using MintStores.Models;

namespace MintStores.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductDataController _dataController;
        public ProductService(IProductDataController dataController) 
        {
            _dataController = dataController;
           
        }
        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            return _dataController.GetProductsByCategory(categoryId);
        }
    }
}

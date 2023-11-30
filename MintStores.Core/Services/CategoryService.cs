using MintStores.Core;
using MintStores.Core.Interfaces.DataRepositories;
using MintStores.Core.Model;
using MintStores.Core.Services;

namespace MintStores.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDataRepository _categoriesDR;
        private readonly IBaseDataRepository<Category> _categoriesBaseDC;
        public CategoryService(ICategoryDataRepository categoryDataRepository, IBaseDataRepository<Category>  baseDataRepository)
        {
            _categoriesBaseDC = baseDataRepository;
            _categoriesDR = categoryDataRepository;
        }

        public IEnumerable<Category> GetAllItems()
        {
            return _categoriesBaseDC.GetAllItems();
        }

        public Category GetItemById(int id)
        {
            return _categoriesBaseDC.GetItemById(id);
        }

        public Category CreateItem(Category newItem)
        {
            if (!_categoriesBaseDC.CreateItem(newItem))
                throw new Exception("Failed to create category");

            return _categoriesBaseDC.GetLastItem();
        }

        public Category UpdateItem(int id, Category updatedItem)
        {
            // Assuming you have an UpdateCategory method in your data controller
            // If not, you need to implement it.
            var success = _categoriesBaseDC.UpdateItem(id, updatedItem);
            if (!success)
            {
                throw new Exception($"Failed to update category with id {id}");
            }

            return _categoriesBaseDC.GetItemById(id);
        }

        public void DeleteItem(int id)
        {
            // Assuming you have a DeleteCategory method in your data controller
            // If not, you need to implement it.
            var success = _categoriesBaseDC.DeleteItem(id);
            if (!success)
            {
                throw new Exception($"Failed to delete category with id {id}");
            }
        }

        public Category GetLastItem()
        {
            return _categoriesBaseDC.GetLastItem();
        }
    }
}

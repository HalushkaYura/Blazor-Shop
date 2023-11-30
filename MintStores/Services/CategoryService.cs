using MintStores.DataControllers;
using MintStores.Interfaces;
using MintStores.Interfaces.Services;
using MintStores.Models;

namespace MintStores.Services
{
    public class CategoryService 
    {
        private readonly CategoryDataController _categoriesDC;

        public CategoryService(CategoryDataController categoryDataController)
        {
            _categoriesDC = categoryDataController;
        }

        public IEnumerable<Category> GetAllItems()
        {
            return _categoriesDC.GetAllItems();
        }

        public Category GetItemById(int id)
        {
            return _categoriesDC.GetItemById(id);
        }

        public Category CreateItem(Category newItem)
        {
            if (!_categoriesDC.CreateItem(newItem))
                throw new Exception("Failed to create category");

            return _categoriesDC.GetLastItem();
        }

        public Category UpdateItem(int id, Category updatedItem)
        {
            // Assuming you have an UpdateCategory method in your data controller
            // If not, you need to implement it.
            var success = _categoriesDC.UpdateItem(id, updatedItem);
            if (!success)
            {
                throw new Exception($"Failed to update category with id {id}");
            }

            return _categoriesDC.GetItemById(id);
        }

        public void DeleteItem(int id)
        {
            // Assuming you have a DeleteCategory method in your data controller
            // If not, you need to implement it.
            var success = _categoriesDC.DeleteItem(id);
            if (!success)
            {
                throw new Exception($"Failed to delete category with id {id}");
            }
        }

        public Category GetLastItem()
        {
            return _categoriesDC.GetLastItem();
        }
    }
}

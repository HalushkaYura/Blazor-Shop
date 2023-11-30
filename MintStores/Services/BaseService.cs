using MintStores.Interfaces;

namespace MintStores.Services
{
    public class BaseService<T> : IBaseService<T>
    {
        private readonly IDataController<T> _dataController;

        public BaseService(IDataController<T> dataController)
        {
            _dataController = dataController;
        }

        public IEnumerable<T> GetAllItems()
        {
            return _dataController.GetAllItems();
        }

        public T GetItemById(int id)
        {
            return _dataController.GetItemById(id);
        }

        public bool CreateItem(T newItem)
        {
            return _dataController.CreateItem(newItem);
        }

        public bool UpdateItem(int id, T updateItem)
        {
            return _dataController.UpdateItem(id, updateItem);
        }

        public T GetLastItem()
        {
           return _dataController.GetLastItem();
        }

        public bool DeleteItem(int id)
        {
            return _dataController.DeleteItem(id);
        }
    }
}

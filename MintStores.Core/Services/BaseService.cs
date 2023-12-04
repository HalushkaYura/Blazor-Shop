using MintStores.Core;

namespace MintStores.Services
{
    public class BaseService<T> : IBaseService<T>
    {
        private readonly IBaseDataRepository<T> _dataRepository;

        public BaseService(IBaseDataRepository<T> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public IEnumerable<T> GetAllItems()
        {
            return _dataRepository.GetAllItems();
        }

        public T GetItemById(int id)
        {
            return _dataRepository.GetItemById(id);
        }

        public bool CreateItem(T newItem)
        {
            return _dataRepository.CreateItem(newItem);
        }

        public bool UpdateItem(int id, T updateItem)
        {
            return _dataRepository.UpdateItem(id, updateItem);
        }

        public T GetLastItem()
        {
           return _dataRepository.GetLastItem();
        }

        public bool DeleteItem(int id)
        {
            return _dataRepository.DeleteItem(id);
        }
    }
}

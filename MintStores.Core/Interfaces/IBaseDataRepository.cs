namespace MintStores.Core
{
    public interface IBaseDataRepository<T>
    {
        IEnumerable<T> GetAllItems();
        T GetItemById(int id);
        T GetLastItem();
        bool CreateItem(T newItem);
        bool UpdateItem(int id, T updatedItem);
        bool DeleteItem(int id);
        
    }
}

namespace MintStores.Interfaces
{
    public interface IBaseService<T>
    {
        IEnumerable<T> GetAllItems();
        T GetItemById(int id);
        bool CreateItem(T newItem);
        bool UpdateItem(int id, T updateItem);
        T GetLastItem();
        bool DeleteItem(int id);
    }
}

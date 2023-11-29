namespace MintStores.Interfaces
{
    public interface IDataController
    {
        IEnumerable<T> GetAllItems<T>();
        T GetItemById<T>(int id);
        bool CreateItem<T>(T newItem);
        T UpdateItem<T>(int id, T updatedItem);
        bool DeleteItem<T>(int id);
    }
}

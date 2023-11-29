namespace MintStores.Services
{
    public interface IBaseService<T>
    {
        IEnumerable<T> GetAllItems();
        T GetItemById(int id);
        T CreateItem(T newItem);
        T UpdateItem(int id, T updateItem);
        void DeleteItem(int id);
    }
}

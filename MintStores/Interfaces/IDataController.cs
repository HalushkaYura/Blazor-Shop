﻿namespace MintStores.Interfaces
{
    public interface IDataController<T>
    {
        IEnumerable<T> GetAllItems();
        T GetItemById(int id);
        T GetLastItem();
        bool CreateItem(T newItem);
        bool UpdateItem(int id, T updatedItem);
        bool DeleteItem(int id);
        
    }
}

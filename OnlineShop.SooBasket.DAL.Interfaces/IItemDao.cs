using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.DAL.Interfaces;

public interface IItemDao
{
    Task AddItemAsync(Item item);
    Task<Item> GetItemAsync(int id);
    Task<bool> RemoveItemAsync(int id);
    Task UpdateItemAsync(Item item);
}
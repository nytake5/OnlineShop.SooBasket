using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.BLL.Interfaces;

public interface IItemLogic
{
    Task AddItemAsync(Item item);
    Task<Item> GetItemAsync(int id);
    Task<bool> RemoveItemAsync(int id);
    Task UpdateItemAsync(Item item);
}
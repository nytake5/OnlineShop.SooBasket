using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.DAL.Interfaces;

public interface IShoppingBasketDao
{
    Task AddItemAsync(int id, Item item);
    Task<ShoppingBasket> GetShoppingBasketAsync(int id);
    Task<bool> RemoveShoppingBasketAsync(int id);
    Task CloseShoppingBasketAsync(int id);
}
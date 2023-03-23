using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.BLL.Interfaces;

public interface IShoppingBasketLogic
{
    Task AddItemAsync(Item item);
    Task<ShoppingBasket> GetShoppingBasketAsync(int id);
    Task<bool> RemoveShoppingBasketAsync(int id);
    Task CloseShoppingBasketAsync(int id);
}
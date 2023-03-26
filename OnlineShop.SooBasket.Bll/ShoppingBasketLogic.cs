using Microsoft.Extensions.Logging;
using OnlineShop.SooBasket.BLL.Interfaces;
using OnlineShop.SooBasket.DAL.Interfaces;
using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.Bll;

public class ShoppingBasketLogic : BaseLogic, IShoppingBasketLogic
{
    public ShoppingBasketLogic(
        IShoppingBasketDao dao,
        ILogger<ShoppingBasketLogic> logger) 
        : base(logger)
    {
    }
    
    public Task AddItemAsync(Item item)
    {
        throw new NotImplementedException();
    }

    public Task<ShoppingBasket> GetShoppingBasketAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveShoppingBasketAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task CloseShoppingBasketAsync(int id)
    {
        throw new NotImplementedException();
    }

}
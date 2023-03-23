using Microsoft.Extensions.Logging;
using OnlineShop.SooBasket.BLL.Interfaces;
using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.Bll;

public class ItemLogic : BaseLogic, IItemLogic
{
    public ItemLogic(
            ILogger<ItemLogic> logger)
        : base(logger)
    {
    }

    public Task AddItemAsync(Item item)
    {
        throw new NotImplementedException();
    }

    public Task<Item> GetItemAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveItemAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateItemAsync(Item item)
    {
        throw new NotImplementedException();
    }
}
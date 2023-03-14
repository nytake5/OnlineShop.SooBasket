using Microsoft.EntityFrameworkCore;
using OnlineShop.SooBasket.DAL.Interfaces;
using OnlineShop.SooBasket.EFDal.DbContexts;
using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.EFDal;

public class ShoppingBasketDao : BaseDao, IShoppingBasketDao
{
    protected ShoppingBasketDao(NpgsqlContext dbContext) 
        : base(dbContext)
    {
    }

    public async Task AddItemAsync(int id, Item item)
    {
        var basket = await GetShoppingBasketAsync(id);
        var basketItems = basket.Items.ToList();
        basketItems.Add(item);
        basket.Items = basketItems;
        DbContext.ShoppingBaskets.Update(basket);
        await DbContext.SaveChangesAsync();
    }

    public async Task<ShoppingBasket> GetShoppingBasketAsync(int id)
    {
        var basket = await DbContext.ShoppingBaskets
            .FirstOrDefaultAsync(b => b.Id == id);
        
        return basket;
    }

    public async Task<bool> RemoveShoppingBasketAsync(int id)
    {
        var basket = await GetShoppingBasketAsync(id);
        DbContext.ShoppingBaskets.Remove(basket);
        var entitiesCnt = await DbContext.SaveChangesAsync();
        return entitiesCnt != 0;
    }

    public async Task CloseShoppingBasketAsync(int id)
    {
        var basket = await DbContext.ShoppingBaskets
            .FirstOrDefaultAsync(b => b.Id == id);
        if (basket != null)
        {
            basket.IsClosed = true;
            DbContext.ShoppingBaskets.Update(basket);
            await DbContext.SaveChangesAsync();
        }
    }
}
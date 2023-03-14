using Microsoft.EntityFrameworkCore;
using OnlineShop.SooBasket.DAL.Interfaces;
using OnlineShop.SooBasket.EFDal.DbContexts;
using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.EFDal;

public class ItemDao : BaseDao, IItemDao
{
    protected ItemDao(NpgsqlContext dbContext) 
        : base(dbContext)
    {
    }

    public async Task AddItemAsync(Item item)
    {
        await DbContext.Items.AddAsync(item);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Item> GetItemAsync(int id)
    {
        var item = await DbContext.Items
            .FirstOrDefaultAsync(i => i.Id == id);
        return item;
    }

    public async Task<bool> RemoveItemAsync(int id)
    {
        var item = await GetItemAsync(id);
        DbContext.Items.Remove(item);
        var entitiesCnt = await DbContext.SaveChangesAsync();
        return entitiesCnt != 0;
    }

    public async Task UpdateItemAsync(Item item)
    {
        DbContext.Update(item);
        await DbContext.SaveChangesAsync();
    }
}
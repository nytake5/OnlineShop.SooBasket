using Microsoft.EntityFrameworkCore;
using OnlineShop.SooBasket.DAL.Interfaces;
using OnlineShop.SooBasket.EFDal.DbContexts;
using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.EFDal;

public class ImageItemDao : BaseDao, IImageItemDao
{
    protected ImageItemDao(NpgsqlContext dbContext)
        : base(dbContext)
    {
    }

    public async Task AddImageForItemAsync(ImageItem imageItem)
    {
        await DbContext.ImageItems.AddAsync(imageItem);
        await DbContext.SaveChangesAsync();
    }

    public async Task<ImageItem> GetImageItemAsync(int imageId);
    {
        var result = await DbContext.ImageItems
            .FirstAsync(item => item.Id == imageId);
        return result;
    }

    public async Task<bool> RemoveImageAsync(int imageId)
    {
        var image = await GetImageItemAsync(imageId);
        DbContext.ImageItems.Remove(image);
        var cntChanges = await DbContext.SaveChangesAsync();
        return cntChanges != 0;
    }
}
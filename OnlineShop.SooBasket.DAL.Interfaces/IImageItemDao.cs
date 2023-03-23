using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.DAL.Interfaces;

public interface IImageItemDao
{
    Task AddImageForItemAsync(ImageItem imageItem); 
    Task<ImageItem> GetImageItemAsync(int imageId);
    Task<bool> RemoveImageAsync(int imageId);
}
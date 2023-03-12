using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.DAL.Interfaces;

public interface ICategoryDao
{
    IAsyncEnumerable<Item> GetCategoryItemsAsync(int id, int offset, int limit);
    Task AddCategoryAsync(Category category);
}
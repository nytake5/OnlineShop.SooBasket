using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.BLL.Interfaces;

public interface ICategoryLogic
{
    IAsyncEnumerable<Item> GetCategoryItemsAsync(int id, int offset, int limit);
    Task AddCategoryAsync(Category category);
}
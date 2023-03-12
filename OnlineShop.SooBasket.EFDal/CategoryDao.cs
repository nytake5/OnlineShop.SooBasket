using OnlineShop.SooBasket.DAL.Interfaces;
using OnlineShop.SooBasket.EFDal.DbContexts;
using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.EFDal;

public class CategoryDao : BaseDao, ICategoryDao
{
    public CategoryDao(NpgsqlContext context)
        : base(context)
    {
    }
    
    public async IAsyncEnumerable<Item> GetCategoryItemsAsync(
        int id, 
        int offset, 
        int limit)
    {
        var currentCategory = DbContext.Categories
            .FirstOrDefault(c => c.Id == id);
        var items = currentCategory?.ListItem
            .Skip(offset).Take(limit);
        
        if (items == null)
        {
            yield break;
        }
        
        foreach (var item in items)
        {
            yield return item;
        }
    }

    public async Task AddCategoryAsync(Category category)
    {
        await DbContext.Categories.AddAsync(category);
        await DbContext.SaveChangesAsync();
    }
}
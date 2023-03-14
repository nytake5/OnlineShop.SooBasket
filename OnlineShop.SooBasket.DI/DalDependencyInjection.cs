using Microsoft.Extensions.DependencyInjection;
using OnlineShop.SooBasket.DAL.Interfaces;
using OnlineShop.SooBasket.EFDal;

namespace OnlineShop.SooBasket.DI;

public static class DalDependencyInjection
{
    public static void AddDalDependency(IServiceCollection services)
    {
        services.AddSingleton<IUserDao, UserDao>();
        services.AddSingleton<IItemDao, ItemDao>();
        services.AddSingleton<ICategoryDao, CategoryDao>();
        services.AddSingleton<IShoppingBasketDao, ShoppingBasketDao>();
    }
}
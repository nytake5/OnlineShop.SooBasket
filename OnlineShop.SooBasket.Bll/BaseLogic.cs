using Microsoft.Extensions.Logging;
using OnlineShop.SooBasket.EFDal;

namespace OnlineShop.SooBasket.Bll;

public abstract class BaseLogic
{
    protected readonly ILogger Logger;

    protected BaseLogic(ILogger<BaseLogic> logger)
    {
        Logger = logger;
    }
}
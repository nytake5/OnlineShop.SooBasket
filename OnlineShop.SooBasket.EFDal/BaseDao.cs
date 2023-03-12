using OnlineShop.SooBasket.EFDal.DbContexts;

namespace OnlineShop.SooBasket.EFDal;

public class BaseDao : IAsyncDisposable
{
    protected readonly NpgsqlContext DbContext;

    protected BaseDao(NpgsqlContext dbContext)
    {
        DbContext = dbContext;
    }

    public async ValueTask DisposeAsync()
    {
        await DbContext.DisposeAsync();
    }
}
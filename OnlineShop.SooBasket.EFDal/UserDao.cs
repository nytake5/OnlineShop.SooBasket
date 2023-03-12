using Microsoft.EntityFrameworkCore;
using OnlineShop.SooBasket.DAL.Interfaces;
using OnlineShop.SooBasket.EFDal.DbContexts;
using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.EFDal;

public class UserDao : BaseDao, IUserDao
{
    
    public UserDao(NpgsqlContext context)
    : base(context)
    {
    }

    public async Task<User> GetUserAsync(int id)
    {
        var user = await DbContext.Users
            .FirstOrDefaultAsync(u => u.Id == id);
        
        return user;
    }

    public async Task<User> GetUserAsync(string login)
    {
        var user = await DbContext.Users
            .FirstOrDefaultAsync(u => u.Login == login);
        
        return user;
    }

    public async Task<bool> CheckUserAsync(string login, string password)
    {
        var user = await DbContext.Users
            .FirstOrDefaultAsync(u => 
                u.Login == login
                && u.Password == password);
        
        return user != null;
    }

    public async Task AddUserAsync(User user)
    {
        await DbContext.AddAsync(user);
        await DbContext.SaveChangesAsync();
    }

    public async Task<bool> RemoveUserAsync(int id)
    {
        var user = await GetUserAsync(id);

        DbContext.Users.Remove(user);
        var entitiesCnt = await DbContext.SaveChangesAsync();
        return entitiesCnt != 0;
    }

    public async Task UpdateUserAsync(User user)
    {
        DbContext.Users.Update(user);
        await DbContext.SaveChangesAsync();
    }
}
using Microsoft.Extensions.Logging;
using OnlineShop.SooBasket.BLL.Interfaces;
using OnlineShop.SooBasket.DAL.Interfaces;
using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.Bll;

public class UserLogic : BaseLogic, IUserLogic
{
    private readonly IUserDao _dao;
    
    public UserLogic(
        ILogger<UserLogic> logger, 
        IUserDao dao) 
        : base(logger)
    {
        _dao = dao;
    }
    
    public async Task<User> GetUserAsync(int id)
    {
        var result = await _dao.GetUserAsync(id);

        return result;
    }

    public async Task<User> GetUserAsync(string login)
    {
        var result = await _dao.GetUserAsync(login);

        return result;
    }

    public async Task<bool> CheckUserAsync(string login, string password)
    {
        var isExist = await _dao.CheckUserAsync(login, password);

        return isExist;
    }

    public async Task<bool> RemoveUserAsync(int id)
    {
        var isRemoved = await _dao.RemoveUserAsync(id);

        return isRemoved;
    }

    public async Task UpdateUserAsync(User user)
    {
        await _dao.UpdateUserAsync(user);
    }

    public async Task AddUserAsync(User user)
    {
        await _dao.AddUserAsync(user);
    }
}
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
        try
        {
            Logger.LogInformation("Try to take user by Id, Id = {Id}",
                id);
            
            var result = await _dao.GetUserAsync(id);
            
            Logger.LogInformation("Success take user by Id, Id = {Id}",
                id);
            return result;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, 
                "Error take user by Id, Id = {Id}", id);
            throw;
        }
    }

    public async Task<User> GetUserAsync(string login)
    {
        try
        {
            Logger.LogInformation("Try to take user by Login, Login = {Login}",
                login);

            var result = await _dao.GetUserAsync(login);
            Logger.LogInformation("Success take user by Login, Login = {Login}",
                login);
            return result;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, 
                "Error take user by Login, Login = {Login}",
                login);
            throw;
        }
    }

    public async Task<bool> CheckUserAsync(string login, string password)
    {
        try
        {
            Logger.LogInformation("Try check user, Login = {Login}",
                login);
            var isExist = await _dao.CheckUserAsync(login, password);
            Logger.LogInformation("Success check user by login, Login = {Login}",
                login);
            return isExist;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, 
                "Error check user by login, Login = {Login}",
                login);
            throw;
        }
    }

    public async Task<bool> RemoveUserAsync(int id)
    {
        try
        {
            Logger.LogInformation("Try remove user by Id, Id = {Id}",
                id);
            var isRemoved = await _dao.RemoveUserAsync(id);
            Logger.LogInformation("Success remove user by Id, Id = {Id}",
                id);
            return isRemoved;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, 
                "Error remove user by Id, Id = {Id}",
                id);
            throw;
        }
    }

    public async Task UpdateUserAsync(User user)
    {
        try
        {
            Logger.LogInformation("Try update user, Id = {Id}",
                user.Id);
            
            await _dao.UpdateUserAsync(user);
            Logger.LogInformation("Success update user, Id = {Id}",
                user.Id);
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, 
                "Error when update user, Id = {Id}",
                user.Id);
            throw;
        }
    }

    public async Task AddUserAsync(User user)
    {
        try
        {            
            Logger.LogInformation("Try add user, Login = {Login}",
                user.Login);
            await _dao.AddUserAsync(user);
            Logger.LogInformation("Success add user, Login = {Login}",
                user.Login);
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, 
                "Error add user, Login = {Login}",
                user.Login);
            throw;
        }
    }
}
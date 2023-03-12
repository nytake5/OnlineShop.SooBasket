using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.DAL.Interfaces;

public interface IUserDao
{
    Task<User> GetUserAsync(int id);
    Task<User> GetUserAsync(string login);
    Task<bool> CheckUserAsync(string login, string password);
    Task AddUserAsync(User user);
    Task<bool> RemoveUserAsync(int id);
    Task UpdateUserAsync(User user);
}
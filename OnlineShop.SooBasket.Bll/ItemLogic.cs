using Microsoft.Extensions.Logging;
using OnlineShop.SooBasket.BLL.Interfaces;
using OnlineShop.SooBasket.DAL.Interfaces;
using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.Bll;

public class ItemLogic : BaseLogic, IItemLogic
{
    private readonly IItemDao _dao;

    public ItemLogic(
        IItemDao dao,
        ILogger<ItemLogic> logger)
        : base(logger)
    {
        _dao = dao;
    }

    public async Task AddItemAsync(Item item)
    {
        try
        {
            Logger.LogInformation("Try add item, Id = {Id}",
                item.Id);
            await _dao.AddItemAsync(item);
            Logger.LogInformation("Success add item, Id = {Id}",
                item.Id);
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Error when add item, {Id}",
                item.Id);
            throw;
        }
    }

    public async Task<Item> GetItemAsync(int id)
    {
        try
        {
            Logger.LogInformation("Try get item by Id, Id = {Id}",
                id);
            var result = await _dao.GetItemAsync(id);
            Logger.LogInformation("Success get item by Id, Id = {Id}",
                id);
            return result;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Error get item, {Id}",
                id);
            throw;
        }
    }

    public async Task<bool> RemoveItemAsync(int id)
    {
        try
        {
            Logger.LogInformation("Try remove item by Id, Id = {Id}",
                id);
            var result = await _dao.RemoveItemAsync(id);
            Logger.LogInformation("Success remove item by Id, Id = {Id}",
                id);
            return result;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Error remove item, {Id}",
                id);
            throw;
        }
    }

    public async Task UpdateItemAsync(Item item)
    {
        try
        {
            Logger.LogInformation("Try update item by Id, Id = {Id}",
                item.Id);
            await _dao.UpdateItemAsync(item);
            Logger.LogInformation("Success update item by Id, Id = {Id}",
                item.Id);
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Error update item, {Id}",
                item.Id);
            throw;
        }
    }
}
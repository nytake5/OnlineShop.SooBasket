﻿namespace OnlineShop.SooBasket.Entities;

public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public Role Role { get; set; }
    public IEnumerable<ShoppingBasket> ShoppingBaskets { get; set; }
}
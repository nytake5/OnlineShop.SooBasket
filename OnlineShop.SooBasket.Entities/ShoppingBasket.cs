namespace OnlineShop.SooBasket.Entities;

public class ShoppingBasket
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public IEnumerable<Item> Items { get; set; }
}
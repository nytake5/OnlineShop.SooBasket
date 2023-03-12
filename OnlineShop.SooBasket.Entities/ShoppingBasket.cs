namespace OnlineShop.SooBasket.Entities;

public class ShoppingBasket
{
    public int Id { get; set; }
    public bool IsClosed { get; set; }
    public IEnumerable<Item> Items { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
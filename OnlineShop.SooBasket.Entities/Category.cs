namespace OnlineShop.SooBasket.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<Item> ListItem { get; set; }
}
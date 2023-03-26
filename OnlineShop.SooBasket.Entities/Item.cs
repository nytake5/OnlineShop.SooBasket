namespace OnlineShop.SooBasket.Entities;

public class Item
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Brand { get; set; }
    public string Article { get; set; }
    public string CountryDevelop { get; set; }
    public decimal Cost { get; set; }
    public IEnumerable<ImageItem> Images { get; set; }
    public IEnumerable<Category> Categories { get; set; }
    public IEnumerable<ShoppingBasket> ShoppingBaskets { get; set; }
}
using System.Drawing;

namespace OnlineShop.SooBasket.Entities;

public class ImageItem
{
    public int Id { get; set; }
    public byte[] Image { get; set; }
    public int ItemId { get; set; }
    public Item? Item { get; set; }
}   
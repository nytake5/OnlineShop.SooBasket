using Microsoft.EntityFrameworkCore;
using OnlineShop.SooBasket.Entities;

namespace OnlineShop.SooBasket.EFDal.DbContexts;

public sealed class NpgsqlContext : DbContext
{
    public NpgsqlContext(DbContextOptions<NpgsqlContext> options) 
        : base(options)
    {
        Database.ExecuteSql(
            $"ALTER TABLE ImageItem ALTER COLUMN Image SET STORAGE EXTERNAL"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        RegisterUser(modelBuilder);
        RegisterCategory(modelBuilder);
        RegisterItem(modelBuilder);
        RegisterShoppingBasket(modelBuilder);
        RegisterImageItem(modelBuilder);
    }

    private void RegisterImageItem(ModelBuilder modelBuilder)
    {
        var imageItem = modelBuilder.Entity<ImageItem>();
        
        imageItem.HasKey(i => i.Id);
        imageItem.Property(i => i.Image).IsRequired();
        
        imageItem.HasOne(i => i.Item)
            .WithMany(i => i.Images)
            .HasForeignKey(i => i.ItemId);
    }

    private void RegisterShoppingBasket(ModelBuilder modelBuilder)
    {
        var shoppingBasket = modelBuilder.Entity<ShoppingBasket>();

        shoppingBasket.HasKey(s => s.Id);
        shoppingBasket.HasMany<Item>(s => s.Items)
            .WithMany(i => i.ShoppingBaskets);
        shoppingBasket.HasOne(s => s.User)
            .WithMany(u => u.ShoppingBaskets)
            .HasForeignKey(s => s.UserId);
    }

    private void RegisterItem(ModelBuilder modelBuilder)
    {
        var items = modelBuilder.Entity<Item>();

        items.HasKey(i => i.Id);
        items.Property(i => i.Title).IsRequired();
        items.Property(i => i.Article).IsRequired();
        items.Property(i => i.Brand).IsRequired();
        items.Property(i => i.CountryDevelop).IsRequired();
        items.Property(i => i.Cost).IsRequired();

        items.HasMany<ImageItem>(i => i.Images)
            .WithOne(i => i.Item);
    }

    private void RegisterCategory(ModelBuilder modelBuilder)
    {
        var categories = modelBuilder.Entity<Category>();

        categories.HasKey(c => c.Id);
        categories.Property(c => c.Name).IsRequired();
        categories.HasMany<Item>(c => c.ListItem)
            .WithMany(i => i.Categories);
    }

    private void RegisterUser(ModelBuilder modelBuilder)
    {
        var users = modelBuilder.Entity<User>();
            
        users.HasKey(u => u.Id);
        users.Property(u => u.Login).IsRequired();
        users.Property(u => u.Password).IsRequired();
        users.Property(u => u.Role).IsRequired();
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ImageItem> ImageItems { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ShoppingBasket> ShoppingBaskets { get; set; }
}
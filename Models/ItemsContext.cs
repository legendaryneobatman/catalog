using Microsoft.EntityFrameworkCore;

namespace Catalog.Models;

public class ItemsContext : DbContext
{
    public virtual DbSet<Item> Items { get; set; }
    private string DbPath { get; }

    public ItemsContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "items.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={DbPath}");
    }
}
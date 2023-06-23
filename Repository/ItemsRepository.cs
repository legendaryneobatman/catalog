using Catalog.DTO;
using Catalog.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Repository;

interface IItemRepository
{
    public IEnumerable<List<Item>?> Get();
    public Item CreateItem(CreateItemDto itemDto);
}

public class ItemsRepository : IItemRepository
{
    private ItemsContext db = new ItemsContext();
    public  Get()
    {
        return db.Items;
    }

    public Item CreateItem(CreateItemDto itemDto)
    {
        var item = new Item()
        {
            Name = itemDto.Name,
            Description = itemDto.Description,
            Price = itemDto.Price
        };
        
        db.Add(item);
        db.SaveChanges();
        return item;
    }
}
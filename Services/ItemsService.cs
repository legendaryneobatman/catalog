using Catalog.DTO;
using Catalog.Models;
using Catalog.Repository;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Services;
public class ItemsService
{
    private ItemsRepository repository = new ItemsRepository();
    
    public DbSet<Item> Get()
    {
        return repository.Get();
    }

    // public ItemDto? GetById(Guid id)
    // {
    //     return Items.SingleOrDefault(item => item.Id == id);
    // }
    //
    public Item CreateItem(CreateItemDto itemDto)
    {
        return repository.CreateItem(itemDto);
    }
    //
    // public ItemDto UpdateItem(ItemDto itemDto)
    // {
    //     var existingItem = Items.SingleOrDefault(item => item.Id == itemDto.Id);
    //     if (existingItem == null)
    //     {
    //         throw new HttpRequestException("Item not found");
    //     }
    //
    //     return existingItem;
    // }
    //
    // public void DeleteItem(Guid id)
    // {
    //     var existingItem = Items.SingleOrDefault(item => item.Id == id);
    //     if (existingItem == null)
    //     {
    //         throw new HttpRequestException("Item not found");
    //     }
    //
    //     Items.Remove(existingItem);
    // }
}
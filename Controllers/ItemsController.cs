using Catalog.DTO;
using Catalog.Models;
using Catalog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly ItemsService _itemsService = new ItemsService();
            
        [HttpGet]
        public IEnumerable<List<Item>> Get()
        {
            return _itemsService.Get();
        }

        // [HttpGet("{id}")]
        // public ItemDto? GetById(Guid id)
        // {
        //     return itemsService.GetById(id);
        // }
        //
        [HttpPost]
        public Item CreateItem(CreateItemDto itemDto)
        {
            return _itemsService.CreateItem(itemDto);
        }
        //
        // [HttpPut]
        // public ItemDto UpdateItem(ItemDto itemDto)
        // {
        //     return itemsService.UpdateItem(itemDto);
        // }
        //
        // [HttpDelete("{id}")]
        // public void DeleteItem(Guid id)
        // {
        //     itemsService.DeleteItem(id);
        // }
    }
}
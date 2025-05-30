using Inventario.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventario.api.Controllers
{
    [Route("api/InventoryItem")]
    [ApiController]
    public class InventoryItemController : ControllerBase
    {
        private static List<ItemModel> InventoryItemList = new List<ItemModel>
        {
            new ItemModel
            {
                Id = 1,
                Name = "Item 1",
                Description = "Description 1",
                IsAvailable = true,
                RackName = "Rack 1",
                RackLevel = "Level 1",
                RackSection = "Section 1",
                RackContainer = "Container 1"
            },
            new ItemModel
            {
                Id = 2,
                Name = "Item 2",
                Description = "Description 2",
                IsAvailable = false,
                RackName = "Rack 2",
                RackLevel = "Level 2",
                RackSection = "Section 2",
                RackContainer = "Container 2"
            }
        };
        public InventoryItemController()
        {

        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(InventoryItemList);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var item = InventoryItemList.FirstOrDefault(i => i.Id == id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create()
        {
            InventoryItemList.Add(new ItemModel
            {
                Id = InventoryItemList.Count + 1,
                Name = "New Item",
                Description = "Description" + InventoryItemList.Count + 1,
                IsAvailable = true,
                RackName = "Rack" + InventoryItemList.Count + 1,
                RackLevel = "Level" + InventoryItemList.Count + 1,
                RackSection = "Section" + InventoryItemList.Count + 1,
                RackContainer = "Container" + InventoryItemList.Count + 1
            });
            return Ok(InventoryItemList);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id)
        {
            var item = InventoryItemList.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                item.Name = "New name";
                item.IsAvailable = false;
                return Ok(item);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var item = InventoryItemList.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                InventoryItemList.Remove(item);
                return Ok();
            }
            else
                return NotFound();
        }
    }
}

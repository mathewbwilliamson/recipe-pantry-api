using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RecipePantry.Data;
using RecipePantry.Models;

namespace RecipePantry.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly MockRecipePantryRepo _repository = new MockRecipePantryRepo();
        // GET api/items
        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetAllItems()
        {
            var items = _repository.GetItems();

            return Ok(items);
        }

        // GET api/items/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> GetItemById(int id)
        {
            var item = _repository.GetItemById(id);

            return Ok(item);
        }
    }
}
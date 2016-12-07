using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Piss.Entities;
using Piss.Entities.Repositories;
using Piss.Models.Repositories;

namespace Piss.Controllers
{
    public class ItemsController : ApiController
    {
# region Props
        private IItemsRepository _ItemsRepository { get; set; }
# endregion


        public ItemsController(IItemsRepository itemsRepo)
        {
            _ItemsRepository = itemsRepo;
        }

        // GET: api/Items
        //public IQueryable<Item> GetItems()
        //{
        //    return db.Items;
        //}

        // GET: api/Items/5
        [ResponseType(typeof(Item))]
        public IHttpActionResult GetItem(long id)
        {
            Item item = _ItemsRepository.GetItem(id);

            return Ok();
        }

        //// PUT: api/Items/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutItem(long id, Item item)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != item.ItemID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(item).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ItemExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Items
        //[ResponseType(typeof(Item))]
        //public async Task<IHttpActionResult> PostItem(Item item)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Items.Add(item);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = item.ItemID }, item);
        //}

        //// DELETE: api/Items/5
        //[ResponseType(typeof(Item))]
        //public async Task<IHttpActionResult> DeleteItem(long id)
        //{
        //    Item item = await db.Items.FindAsync(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Items.Remove(item);
        //    await db.SaveChangesAsync();

        //    return Ok(item);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool ItemExists(long id)
        //{
        //    return db.Items.Count(e => e.ItemID == id) > 0;
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using Piss.Entities;
using Piss.Entities.Repositories;

namespace Piss.Models.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly PISSEntities _db = new PISSEntities();

        public ItemsRepository()
        {
            
        }

        // GET: api/Items/5
        [ResponseType(typeof(Item))]
        public Item GetItem(long id)
        {
            Item item = _db.Items.Find(id);
            if (item == null)
            {
                throw new Exception("Item not found");
            }

            return item;
        }

    }
}
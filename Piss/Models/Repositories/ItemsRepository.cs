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
    public class ItemsRepository : IItemTypeRepository
    {
        private readonly PISSEntities _db = new PISSEntities();

        public ItemsRepository()
        {
            
        }

        // GET: api/Items/5
        [ResponseType(typeof(Entities.ItemType))]
        public Entities.ItemType GetItem(long id)
        {
            var item = _db.ItemTypes.Find(id);
            if (item == null)
            {
                throw new Exception("Item not found");
            }

            return item;
        }

    }
}
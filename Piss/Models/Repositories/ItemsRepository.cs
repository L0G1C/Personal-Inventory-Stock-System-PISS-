using System;
using System.Collections;
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
        public Entities.ItemType GetItemType(long id)
        {
            var item = _db.ItemTypes.Find(id);
            if (item == null)
            {
                throw new Exception("Item not found");
            }

            return item;
        }

        [ResponseType(typeof(IEnumerable<Entities.ItemType>))]
        public IEnumerable<Entities.ItemType> GetItemTypes()
        {
            return _db.ItemTypes.ToList();
        }

        [ResponseType(typeof(Entities.ItemType))]
        public Entities.ItemType AddItemType(Entities.ItemType itemType)
        {
            throw new NotImplementedException();
        }
    }
}
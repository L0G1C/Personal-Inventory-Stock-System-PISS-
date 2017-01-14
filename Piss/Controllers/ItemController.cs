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
using AutoMapper;
using Ninject;
using Piss.Models;
using Piss.Entities.Repositories;
using Piss.Models.Repositories;

namespace Piss.Controllers
{
    public class ItemController : ApiController
    {
# region Props
        private IItemRepository ItemsRepository { get; set; }
# endregion

       [Inject]
        public ItemController(IItemRepository itemsRepo)
        {
            ItemsRepository = itemsRepo;
        }

        // GET: api/Item/5
        [ResponseType(typeof(Item))]
        public IHttpActionResult GetItem(long id)
        {
            var Item = Mapper.Map<Entities.Item, Item>( ItemsRepository.GetItem(id));

            return Json(Item);
        }

        // GET: api/Items
        [ResponseType(typeof(List<Item>))]
        public IHttpActionResult GetItems()
        {
            var ItemList = Mapper.Map<IEnumerable<Entities.Item>, IEnumerable<Item>>(ItemsRepository.GetItems());
            
            return Json(ItemList);
        }


    }
}
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
    public class ItemsController : ApiController
    {
# region Props
        private IItemTypeRepository ItemsRepository { get; set; }
# endregion

       [Inject]
        public ItemsController(IItemTypeRepository itemsRepo)
        {
            ItemsRepository = itemsRepo;
        }

        // GET: api/Items/5
        [ResponseType(typeof(ItemType))]
        public IHttpActionResult GetItem(long id)
        {
            var item = Mapper.Map<Entities.ItemType, ItemType>( ItemsRepository.GetItem(id));

            return Ok(item);
        }


    }
}
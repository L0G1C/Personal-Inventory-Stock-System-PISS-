﻿using System;
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
    public class ItemTypeController : ApiController
    {
# region Props
        private IItemTypeRepository ItemsRepository { get; set; }
# endregion

       [Inject]
        public ItemTypeController(IItemTypeRepository itemsRepo)
        {
            ItemsRepository = itemsRepo;
        }

        // GET: api/ItemType/5
        [ResponseType(typeof(ItemType))]
        public IHttpActionResult GetItem(long id)
        {
            var itemType = Mapper.Map<Entities.ItemType, ItemType>( ItemsRepository.GetItemType(id));

            return Json(itemType);
        }

        // GET: api/ItemTypes
        [ResponseType(typeof(List<ItemType>))]
        public IHttpActionResult GetItemTypes()
        {
            var itemTypeList = Mapper.Map<IEnumerable<Entities.ItemType>, IEnumerable<ItemType>>(ItemsRepository.GetItemTypes());
            
            return Json(itemTypeList);
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Piss.Entities;

namespace Piss.App_Start
{
    public class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<ItemType, Models.ItemType>();
                config.CreateMap<Item, Models.Item>();
            });
        }
    }
}
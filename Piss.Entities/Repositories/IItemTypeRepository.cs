using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piss.Entities.Repositories
{
    public interface IItemRepository
    {
        //itemTypes
        ItemType GetItemType(long id);      
        IEnumerable<ItemType> GetItemTypes();

        //items
        Item GetItem(long itemId);
        IEnumerable<Item> GetItems(long itemTypeId);

        ItemType AddItemType(ItemType itemType);
        
    }
}

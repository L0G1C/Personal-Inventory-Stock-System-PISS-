using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piss.Entities.Repositories
{
    public interface IItemTypeRepository
    {
        ItemType GetItemType(long id);
        IEnumerable<ItemType> GetItemTypes();
        ItemType AddItemType(ItemType itemType);
    }
}

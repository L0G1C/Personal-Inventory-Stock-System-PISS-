using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piss.Entities.Repositories
{
    public interface IItemRepository
    {
        Item GetItem(long id);
        IEnumerable<Item> GetItems();
        Item AddItem(Item Item);
    }
}

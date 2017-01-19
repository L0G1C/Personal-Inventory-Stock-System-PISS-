using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Piss.Models
{
    public class Item
    {
        public long ItemId { get; set; }
        public long ItemTypeId { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsBorrowed { get; set; }  
    }
}
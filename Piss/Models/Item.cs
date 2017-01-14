using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Piss.Models
{
    public class Item
    {
        public long ItemTypeId { get; set; }
        public string Description { get; set; }
        public int? ImageId { get; set; }
        public bool IsBorrowed { get; set; }
        public bool IsActive { get; set; }
        public string UserId { get; set; }
    }
}
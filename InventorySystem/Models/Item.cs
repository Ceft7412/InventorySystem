using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Category { get; set; }

        public int Quantity { get; set; }
        public string Supplier { get; set; }
        public string Unit { get; set; }

        public string LastUpdated { get; set; }

        public int MinimumStock { get; set; }
    }
}

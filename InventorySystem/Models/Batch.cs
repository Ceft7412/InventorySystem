using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Batch
    {
        public string BatchID { get; set; } 
        public DateTime date { get; set; }

        public string TransactionType { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{

    public class BatchItem
    {
        public string BatchItemId { get; set; }

        public string BatchId { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; }

        public string Type { get; set; }

        public DateTime? Date { get; set; }

        public string TransactionType { get; set; }
    }
}

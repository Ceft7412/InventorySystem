using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Log
    {

        public int LogID { get; set; }
        public DateTime TimeStamp { get; set; }

        public int UserID { get; set; }

        public string ActionType { get; set; }

        public string TableAffected { get; set; }

        public int RecordID { get; set; }
        public string Description { get; set; }
        public string ModuleName { get; set; }
        public string Status { get; set; }
    }
}

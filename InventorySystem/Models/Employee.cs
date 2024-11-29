using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public int Contact { get; set; }

        public string Address { get; set; }
    }
}

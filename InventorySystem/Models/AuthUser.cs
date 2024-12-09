using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class AuthUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static implicit operator User(AuthUser v)
        {
            throw new NotImplementedException();
        }
    }
}

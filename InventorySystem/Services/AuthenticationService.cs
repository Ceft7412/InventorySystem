using Microsoft.VisualBasic.ApplicationServices;
using System;
using InventorySystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Services
{
    public class AuthenticationService
    {
        public static bool IsAuthenticated { get; private set; }
        public static User CurrentUser { get; private set; }
            
        public void Authenticated()
        {
            IsAuthenticated = true;
        }

        public void Destroy()
        {
            CurrentUser = null;
            IsAuthenticated = false;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Inventory.Model
{
    public class AppUser : IdentityUser
    {
       public string Name { get; set; }

       public string City { get; set; }
       public string Address { get; set; }

      public string Pincode { get; set; }
       
    }
}

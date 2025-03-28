﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class Branch
    {
        public int BranchId { get; set; }

        [Required]
        public string Name { get; set; }

        public string BranchName { get; set; }

        public string Description { get; set; }

        public string CurrencyId { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        [Display(Name = "Contact")]

        public string Contact { get; set; }
    }
}
    
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class Bill
    {
        public int BillId { get; set; }
        [Display(Name ="Bill / Invoice Number" )]

        public string BillName { get; set; }
        [Display(Name = "GRN")]

        public int GoodsReceivedNoteId { get; set; }
        [Display(Name = "VendorDoNumber Delivery Order")]

        public string VendorDoNumber { get;set; }
        [Display(Name = "Vendor Bill / Invoice")]

        public string VendorInvoiceNumber { get; set; }
        [Display(Name = "Bill Date")]

        public DateTimeOffset BillDate {  get; set; }
        [Display(Name = "Bill Due Date")]

        public DateTimeOffset BillDueDate { get; set; }
        [Display(Name = "Bill Type")]

        public int BillTypeId { get; set; }
    }
}

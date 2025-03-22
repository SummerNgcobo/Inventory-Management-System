using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public OrderType OrderType { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public decimal SubTotal { get; set; }

        public decimal ItemDiscount { get; set; }

        public decimal ShippingCharges { get; set; }

        public decimal Total { get; set; }

        public decimal PromoCode { get; set; }

        public decimal Discount { get; set; }

        public decimal GrandTotal { get; set; }
    }
}

namespace Inventory.Model
{
    public enum OrderStatus
    {
        CheckOut, Paid, Failed, Shipped, Delivered, Returned, Complete
    }
}

namespace Inventory.Model
{
    public enum OrderType
    {
        PurchaseOrder, CustomerOrder
    }
}
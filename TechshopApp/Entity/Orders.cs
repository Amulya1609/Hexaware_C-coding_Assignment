using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;

namespace Model
{
    public class Orders
    {
        private decimal totalAmount;

        public int OrderID { get; set; }
        public Customers customer { get; set; }
        public DateTime OrderDate { get; set; }

        // TotalAmount with validation
        public decimal TotalAmount
        {
            get { return totalAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Total amount cannot be negative.");
                }
                totalAmount = value;
            }
        }
        public string OrderStatus { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }

        public Orders(int orderId, Customers customer, DateTime orderDate, decimal totalAmount)
        {
            OrderID = orderId;
            Customers = customer;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            OrderStatus = "Processing";
            OrderDetails = new List<OrderDetails>();
        }
        public Orders() { }
    }
}


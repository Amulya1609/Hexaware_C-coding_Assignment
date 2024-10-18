using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public interface IOrdersDao
    {
        decimal CalculateTotalAmount(int orderid);

        public List<OrderDetails> GetOrderDetails(int orderId);

        public bool UpdateOrderStatus(int orderId, string status);
        public bool CancelOrder(int orderId);
    }
}

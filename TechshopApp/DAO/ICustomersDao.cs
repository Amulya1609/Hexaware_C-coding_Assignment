using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public interface ICustomersDao
    {
        int CalculateTotalOrders(int customerid);
        bool UpdateCustomerInfo(Customers customer);
        Customers GetCustomerDetails(int customerid);
    }
}

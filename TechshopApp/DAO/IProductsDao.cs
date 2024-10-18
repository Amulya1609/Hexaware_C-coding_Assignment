using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public interface IProductsDao
    {
        Products GetProductDetails(int productid);
        bool UpdateProductInfo(Products product);
        bool IsProductInStock(int productid);
    }
}

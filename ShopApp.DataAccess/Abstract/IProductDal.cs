using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{  //product entitysi üzerinden çalışacağım metodlar
    public interface IProductDal:IRepository<Product>
    {
        IEnumerable<Product> GetPopularProducts();

        Product GetProductDetails(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
   public interface IRepository<T>
    {
        T GetById(int id); //kullanıcı dışarıdan bir id bilgisi gönderdiği zaman, Gerekli Tablosundan bulup geriye döndüreceğim.
        T GetOne(Expression<Func<T, bool>> filter); //bulduğu ilk kaydı geri alsın
        List<T> GetAll(Expression<Func<T, bool>> filter=null); //bulduğu bütün kayıtları geri alsın
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

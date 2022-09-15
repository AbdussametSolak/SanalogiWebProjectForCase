using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        //Business katmanında kullanacagımız servis operasyonları
        //için gerekli metot imzalarını yazdık.
        Order Add(Order order);
        IEnumerable<Order> GetAll();
        Order GetById(int orderId);
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Business katmannında kullanacagımız servis operasyonları
    //için gerekli metotlarımızı burada ımplemente ediyoruz.
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            // Data Access katmanına bagımlı oldugumuz ıcın
            // o katmandakı crud operasyonlarına ulasabılmek ıcın
            // Dependency Injection yaptık.
            // Bu sayede daha gevsek bir bagımlılık olustu.
            _orderDal = orderDal;
        }
        public Order Add(Order order) 
        {
            // Sipariş ekleme işlemi
            // Burda iş kuralları yazılabılır
            return _orderDal.Add(order);    
        }

        public IEnumerable<Order> GetAll() 
        {
            // Sipariş listesi getirme işlemi
            // Burda iş kuralları yazılabılır
            return _orderDal.GetAll();
        }

        public Order GetById(int orderId)
        {
            // Idye göre tek bir sipariş getirme işlemi
            // Burda iş kuralları yazılabılır
            return _orderDal.Get(o=>o.orderId==orderId);
        }
    }
}

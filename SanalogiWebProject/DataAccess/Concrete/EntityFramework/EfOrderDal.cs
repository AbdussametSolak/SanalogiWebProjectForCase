using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal: EfGenericRepositoryBase<Order>, IOrderDal
    {
        // Data Access katmanında siparise iliskin
        // crud operasyonlarımız
        // Generic yapıdaki classımız olan EfRepositoryBaseden kalıtım alıyor. 

        //Aynı zamanda IOrderDal ile de soyutladık. 
    }
}

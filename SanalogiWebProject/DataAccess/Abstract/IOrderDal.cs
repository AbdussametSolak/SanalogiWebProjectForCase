using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IOrderDal:IEntityRepository<Order>
    {
        // Data Access katmanında siparise iliskin
        // crud operasyonlarımızın metot imzaları 
        // Generic yapıdaki IEntityRepositoryden kalıtım alıyor. 
        // Birden fazla Dal olabilitesi de dusunulerek
        // Generic interface kullanılmistir.
    }
}

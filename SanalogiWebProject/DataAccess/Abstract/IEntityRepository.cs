using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<TEntity>
        where TEntity : class,new()
        // Kısıtlama uyguladık.
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        TEntity Add(TEntity entity);

        // Dallarımızın metot ımzaları ıcın
        // generic yapıda bir interface olusturuldu.
    }
}

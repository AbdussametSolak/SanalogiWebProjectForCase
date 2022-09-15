using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfGenericRepositoryBase<TEntity > : IEntityRepository<TEntity>
        where TEntity : class, new()

        // Crud Operasyonu implementasyonları için kullanacagımız
        // EfGenericRepositoryBase'e calısacagı Entity belirtilip kısıtlanma konuldu.

        // Dalllarımızın metotları ıcın
        // generic yapıda bir base class olusturuldu.
        // Crud operasyonu ıcın gereklı metotlarımız buradan
        // kalıtım almıs oluyor.

    {
        Context context = new Context(); //Veri tabanına erisim ıcın context sınıfından obje urettık
        DbSet<TEntity> _object; 
        public EfGenericRepositoryBase()
        {
            _object = context.Set<TEntity>();
            // constructor ile Veritabanımızdaki entitylerimiz set ediyoruz.
        }
        public TEntity Add(TEntity entity)
        {
            // Veritaabnımıza Entity eklemek için
            // gerekli operasyon

            var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                return entity;          
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            // Linq sayesinde kendisine parametre gonderilen filtreye(lambda gönderilecek)
            // gore tek bir Entity dondermek ıcın yazılan operasyon

            return _object.SingleOrDefault(filter);
        }

        public IEnumerable<TEntity> GetAll()
        {
            // Entitylerimizi IEnumerable tipinde bir liste
            // dondurmek ıcın yazılan operasyon
            return _object.ToList();
        }
    }
}

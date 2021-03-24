using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess
{
    public interface IEntityRepository<T> /*Generic model */ where T : class /*T class olamlı demek (classtan kasıt referans tip)*/,
         IEntity/* Entities -> IEntity sınıfından kural çekecek*/ ,new()/*newlenebiliyor*/
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}

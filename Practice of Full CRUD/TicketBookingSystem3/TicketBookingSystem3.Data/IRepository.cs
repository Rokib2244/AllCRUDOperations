using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem3.Data
{
    public interface IRepository<TEntity, TKey>
        where TEntity: class, IEntity<TKey>
    {
        public void Add(TEntity entity);
        public void Edit(TEntity entityToUpdate);
        public void Remove(TKey id);
        public void Remove(TEntity entityToDelete);

        int GetCount(Expression<Func<TEntity, bool>> filter = null);
        IList<TEntity> GetAll();
        TEntity GetById(TKey id);

    }
}

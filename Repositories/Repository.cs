using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Repositories
{
    internal class Repository<TEntity, TKey, TDataContext> :
       IRepository<TEntity, TKey, TDataContext>
       where TEntity : class where TDataContext : DbContext
    {
        private readonly TDataContext _context;

        public Repository(TDataContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
        }

        public void Delete(TKey key)
        {
            var x = (TEntity)_context.Find(key.GetType(), key);
            _context.Remove(x);

            if (x == null)
            {
                throw new ArgumentNullException(nameof(x));
            }

        }

        public TEntity FindById(TKey key, TKey key1)
        {
           
            return _context.Set<TEntity>()
                   .SingleOrDefault(e => EF.Property<TKey>(e, "From")!.Equals(key) &&
                                         EF.Property<TKey>(e, "To")!.Equals(key1))!;
        }

        public TEntity FindByKey(TKey key)
        {
            var x = (TEntity)_context.Find(key.GetType(), key);
          
            if (x == null)
            {
                throw new ArgumentNullException(nameof(x));
            }
            return x;
        }

        public IQueryable<TEntity> GetAll()
        {
            if (_context == null)
            {
                throw new InvalidOperationException();
            }
            return _context.Set<TEntity>() as IQueryable<TEntity>;

        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            if (_context == null)
            {
                throw new InvalidOperationException();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.EF;
using TaskManager.DAL.Interfaces;
using TaskManager.Middleware.Data.DataClasses.Base;

namespace TaskManager.DAL.Infrastrucrure
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private DbSet<T> _set;
        private readonly DbContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        protected DbSet<T> Set => _set ?? (_set = _context.Set<T>());

        public T Create(T item)
        {
            return Set.Add(item);
        }

        public void Delete(Guid id)
        {
            T item = Set.Find(id);
            if (item != null)
                Set.Remove(item);
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return Set.Where(predicate);
        }

        public T Get(Guid id)
        {
            return Set.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Set;
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}

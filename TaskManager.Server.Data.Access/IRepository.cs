using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Middleware.Data.DataClasses.Base;

namespace TaskManager.Server.Data.Access
{
    public interface IRepository<T> where T : Entity
    {
        T GetById(Guid id);

        Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        IEnumerable<T> GetAll();

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        void Update(T entity);

        void Delete(T entity);

        void DeleteRange(IEnumerable<T> entities);
    }
}

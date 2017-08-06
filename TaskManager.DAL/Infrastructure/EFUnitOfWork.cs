using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskManager.DAL.EF;
using TaskManager.DAL.Interfaces;
using TaskManager.DAL.Interfaces.Repositories;
using TaskManager.DAL.Repositories;

namespace TaskManager.DAL.Infrastrucrure
{
    public class EFUnitOfWork :IUnitOfWork, IDisposable
    {
        #region Private

        private DataContext _context;
        private IUserRepository _userRepository;
        private IDomainTaskRepository _taskRepository;
        private bool _disposed = false;

        private static T SafeCreateOrGet<T>(ref T obj, Func<T> valueFactory) where T : class
        {
            if (obj != null)
            {
                return obj;
            }

            Interlocked.CompareExchange(ref obj, valueFactory(), null);
            return obj;
        }
        #endregion
        public EFUnitOfWork(DataContext context)
        {
            _context = context;
        }

        #region Repositories
        public IUserRepository UserRepository => SafeCreateOrGet(ref _userRepository, () => new UserRepository(_context));
        public IDomainTaskRepository DomainTaskRepository => SafeCreateOrGet(ref _taskRepository, () => new DomainTaskRepository(_context));

        #endregion

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

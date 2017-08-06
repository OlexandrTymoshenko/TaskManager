using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.Interfaces;

namespace TaskManager.Management
{
    public abstract class BaseManager : IDisposable
    {
        private bool _disposed = false;
        protected BaseManager(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        protected IUnitOfWork UnitOfWork { get; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                UnitOfWork.Dispose();
            }
            _disposed = true;
        }
    }
}

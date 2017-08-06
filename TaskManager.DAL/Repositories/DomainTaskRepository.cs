using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.EF;
using TaskManager.DAL.Infrastrucrure;
using TaskManager.DAL.Interfaces;
using TaskManager.DAL.Interfaces.Repositories;
using TaskManager.Middleware.Data.DataClasses;

namespace TaskManager.DAL.Repositories
{
    public class DomainTaskRepository : Repository<DomainTask>,IRepository<DomainTask>,IDomainTaskRepository
    {
        public DomainTaskRepository(DataContext context) : base(context)
        {
        }

        public void DeleteAllTasks(Guid userId)
        {
            Set.RemoveRange(Set.Where(x => x.Id == userId));
        }
    }
}

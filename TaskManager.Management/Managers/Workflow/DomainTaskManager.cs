using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.Interfaces;
using TaskManager.Management.Interfaces;
using TaskManager.Middleware.Data.Api.Workflow;
using TaskManager.Middleware.Data.DataClasses;

namespace TaskManager.Management.Workflow
{
    public class DomainTaskManager : BaseManager, IDomainTaskManager
    {
        public DomainTaskManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public DomainTask Create(CreateDomainTaskRequest req)
        {
            DomainTask task = UnitOfWork.DomainTaskRepository.Create(new DomainTask()
            {
                Title = req.Title,
                Description = req.Description
            });
            UnitOfWork.Save();
            return task;
        }

        public IEnumerable<DomainTask> GetAll(Guid id)
        {
            return UnitOfWork.DomainTaskRepository.Find(x=>x.Id == id);
        }

        public void Remove(Guid id)
        {
            UnitOfWork.DomainTaskRepository.Delete(id);
            UnitOfWork.Save();
        }

        public void RemoveAll(Guid id)
        {
            UnitOfWork.DomainTaskRepository.DeleteAllTasks(id);
            UnitOfWork.Save();
        }

        public void Update(UpdateDomainTaskRequest req)
        {
            DomainTask task = UnitOfWork.DomainTaskRepository.Get(req.Id);
            if (task!=null)
            {
                task.Title = req.Title;
                task.Description = req.Description;
                UnitOfWork.DomainTaskRepository.Update(task);
                UnitOfWork.Save();
            }
        }
    }
}

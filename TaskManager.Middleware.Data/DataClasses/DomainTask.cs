using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Middleware.Data.DataClasses.Base;

namespace TaskManager.Middleware.Data.DataClasses
{
    public class DomainTask : Entity
    {
        public string Description { get; set; }
        public string Title { get; set; }
    }
}

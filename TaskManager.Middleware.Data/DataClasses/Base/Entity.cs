using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Middleware.Data.DataClasses.Base
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Middleware.Data.DataClasses.Base;

namespace TaskManager.Middleware.Data.DataClasses
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        public string Address { get; set; }
        //public Role Role { get; set; }
        //public Guid RoleId { get; set; }
    }
}

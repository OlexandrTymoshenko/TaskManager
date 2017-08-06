using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Middleware.Data.DataClasses;

namespace TaskManager.DAL.EF
{
    public class DefaultDbInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext db)
        {
            db.Users.Add(new User() { Id=Guid.NewGuid(), Name="Bob",PasswordHash = Hash("123456")});
            db.SaveChanges();
        }
        private static String Hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }

    
}

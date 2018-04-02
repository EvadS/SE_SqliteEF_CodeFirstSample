using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqLiteCodeFirstSample.DataBase.context
{

    public class MyDbContextInitializer : SqliteCreateDatabaseIfNotExists <CustomerModel>
    {
 

        public MyDbContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(CustomerModel context)
        {
            context.Set<customer>().Add(new customer() { name="NAME", salary=777});
            context.Set<customer>().Add(new customer() { name = "NAME 3 ", salary = 2777 });
            context.Set<customer>().Add(new customer() { name = "NAME 5 ", salary = 3777 });

            context.Set<customer>().Add(new customer() { name = "NAME 7", salary = 4777 });
        }
    }
}

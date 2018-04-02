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
            work work1 = new work() { name = "work name 1 " };
            work work2 = new work() { name = "work name 2 " };


            context.work.Add(work1);
            context.work.Add(work2);
            context.SaveChanges();

            context.Set<customer>().Add(new customer() { name="NAME", salary=777 , work = work1});
            context.Set<customer>().Add(new customer() { name = "NAME 3 ", salary = 2777, work = work1  });
            context.Set<customer>().Add(new customer() { name = "NAME 5 ", salary = 3777 ,work = work2});            
        }
    }
}

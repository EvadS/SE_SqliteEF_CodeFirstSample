using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqLiteCodeFirstSample.context
{

    public class MyDbContextInitializer : SqliteCreateDatabaseIfNotExists <CustomerModel>
    {
 

        public MyDbContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(CustomerModel context)
        {
            context.Set<customer>().Add(new customer() { name="NAME", salary=777});
        }
    }
}

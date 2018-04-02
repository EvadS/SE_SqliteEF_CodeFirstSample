namespace SqLiteCodeFirstSample.context
{
    using System.Data.Entity;
    using SQLite.CodeFirst;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CustomerModel : DbContext
    {
        public CustomerModel()
            : base("name=customersDB2")
        {
        }

        public virtual DbSet<customer> customer { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //    //MyDbContextInitializer
            // var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<CustomerModel>(modelBuilder);
            // Database.SetInitializer(sqliteConnectionInitializer);

            var contextinitialiser = new MyDbContextInitializer(modelBuilder);
            Database.SetInitializer(contextinitialiser);


        }
    }
}

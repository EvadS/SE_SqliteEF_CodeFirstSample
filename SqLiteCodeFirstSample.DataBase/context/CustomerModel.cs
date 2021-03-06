namespace SqLiteCodeFirstSample.DataBase.context
{
    using System.Data.Entity;

    public partial class CustomerModel : DbContext
    {
        public CustomerModel()
            : base("name=customersDB3")
        {
            Configuration.ProxyCreationEnabled = true;
        }


        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<work> work { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {         
            var contextinitialiser = new MyDbContextInitializer(modelBuilder);
            Database.SetInitializer(contextinitialiser);
        }
    }
}

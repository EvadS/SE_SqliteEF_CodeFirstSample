namespace SqLiteCodeFirstSample.DataBase.context
{
    using SQLite.CodeFirst;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [System.ComponentModel.DataAnnotations.Schema.Table("customer")]
    public partial class customer
    {

        [Autoincrement]
        [Key]
        public long id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string name { get; set; }

        [Column(TypeName = "real")]
        public double salary { get; set; }
    }
}

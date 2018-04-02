namespace SqLiteCodeFirstSample.Properties.DataSources
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        public long id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string name { get; set; }

        [Column(TypeName = "real")]
        public double salary { get; set; }
    }
}

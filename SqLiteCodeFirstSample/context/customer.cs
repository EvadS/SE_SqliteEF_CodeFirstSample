namespace SqLiteCodeFirstSample.context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [System.ComponentModel.DataAnnotations.Schema.Table("customer")]
    public partial class customer
    {       
     
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        [Key, Column(Order = 0)]
        public long id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string name { get; set; }

        [Column(TypeName = "real")]
        public double salary { get; set; }
    }
}

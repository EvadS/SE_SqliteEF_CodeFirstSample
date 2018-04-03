using SQLite.CodeFirst;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqLiteCodeFirstSample.DataBase.context
{


    [System.ComponentModel.DataAnnotations.Schema.Table("work")]
    public partial class work
    {

        [Autoincrement]
        [Key]
        public long id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string name { get; set; }


        public virtual ICollection<customer> customers { get; set; }


        public work()
        {
            customers = new HashSet<customer>();
        }
    }
}

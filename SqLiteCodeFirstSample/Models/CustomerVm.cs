using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqLiteCodeFirstSample.Models
{
  public   class CustomerVm
    {
        public long id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
    }
}

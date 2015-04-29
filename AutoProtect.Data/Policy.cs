using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProtect.Data
{
    public class Policy
    {
        public virtual int ID { get; set; }
        public virtual PolicyHolder Holder { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual DateTime? StateDate { get; set; }
    }
}

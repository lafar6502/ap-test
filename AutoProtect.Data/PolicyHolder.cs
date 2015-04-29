using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProtect.Data
{
    public class PolicyHolder
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual DateTime? DOB { get; set; }

    }
}

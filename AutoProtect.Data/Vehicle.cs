using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProtect.Data
{
    public class Vehicle
    {
        public virtual int Id { get; set; }
        public virtual string Make { get; set; }
        public virtual string Model { get; set; }
        public virtual string Registration { get; set; }
    }
}

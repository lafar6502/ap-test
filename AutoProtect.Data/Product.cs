using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProtect.Data
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual int? Duration { get; set; }
        public virtual Decimal? ClaimLimit { get; set; }
    }
}

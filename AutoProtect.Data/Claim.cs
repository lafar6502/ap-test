using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProtect.Data
{
    public class Claim
    {
        public virtual int Id { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual DateTime? ClaimDate { get; set; }
        public virtual Decimal? Amount { get;set;}
    }
}

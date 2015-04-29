using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace AutoProtect.Data.Mappings
{
    public class ClaimMap : ClassMap<Claim>
    {
        public ClaimMap()
        {
            Id(x => x.Id);
            References(x => x.Policy).Column("PolicyID").Not.Nullable().Not.LazyLoad();
            Map(x => x.ClaimDate);
            Map(x => x.Amount);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace AutoProtect.Data.Mappings
{
    public class PolicyMap : ClassMap<Policy>
    {
        public PolicyMap()
        {
            Id(x => x.ID);
            References(x => x.Product).Column("ProductID").Not.LazyLoad();
            References(x => x.Holder).Column("PolicyHolderID").Not.LazyLoad();
            References(x => x.Vehicle).Column("VehicleID").Not.LazyLoad();
            Map(x => x.StateDate);
        }

    }
}

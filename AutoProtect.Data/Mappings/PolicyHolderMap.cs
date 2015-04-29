using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace AutoProtect.Data.Mappings
{
    public class PolicyHolderMap : ClassMap<PolicyHolder>
    {
        public PolicyHolderMap()
        {
            Id(x => x.Id);
            Map(x => x.FullName);
            Map(x => x.DOB);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace AutoProtect.Data.Mappings
{
    public class ProductMap: ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Map(x => x.Description);
            Map(x => x.Duration);
            Map(x => x.ClaimLimit);
        }
    }
}

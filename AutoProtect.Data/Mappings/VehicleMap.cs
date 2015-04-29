using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace AutoProtect.Data.Mappings
{
    public class VehicleMap : ClassMap<Vehicle>
    {
        public VehicleMap()
        {
            Id(x => x.Id);
            Map(x => x.Make);
            Map(x => x.Model);
            Map(x => x.Registration);
        }
    }
}

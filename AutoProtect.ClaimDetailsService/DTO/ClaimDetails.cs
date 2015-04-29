using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProtect.ClaimDetailsService.DTO
{
    /**
     * Data transfer objects for claim details service
     */
    public class VehicleDetails
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
    }

    public class ProductDetails
    {
        public string Description { get; set; }
        public Decimal ClaimLimit { get; set; }

    }

    public class PolicyDetails
    {
        public int Id { get; set; }
        public string HolderName { get; set; }
        public DateTime? HolderDOB { get; set; }
        public VehicleDetails Vehicle { get; set; }
    }

    public class ClaimDetails
    {
        public decimal Amount { get;set;}
        public PolicyDetails Policy { get;set;}
        public DateTime ClaimDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AutoProtect.ClaimDetailsService
{
    [ServiceContract]
    public interface IClaimDetails
    {
        [OperationContract]
        DTO.ClaimDetails GetClaimDetails(int id);
    }
}

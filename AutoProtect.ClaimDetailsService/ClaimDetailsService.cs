using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AutoProtect.Services;
using NHibernate;

namespace AutoProtect.ClaimDetailsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ClaimDetailsService : IClaimDetails
    {

        public DTO.ClaimDetails GetClaimDetails(int id)
        {
            using (var ses = NHibernateHelper.OpenSession())
            {
                NHSession.CurrentSession = ses;
                var repo = new ClaimRepository();
                var c = repo.GetClaimDetails(id);
                if (c == null) return null;
                var ret = new DTO.ClaimDetails
                {
                    Amount = c.Amount.GetValueOrDefault(),
                    ClaimDate = c.ClaimDate.GetValueOrDefault(),
                    Policy = new DTO.PolicyDetails
                    {
                        HolderDOB = c.Policy.Holder.DOB.GetValueOrDefault(),
                        HolderName = c.Policy.Holder.FullName,
                        Id = c.Policy.ID,
                        Vehicle = new DTO.VehicleDetails
                        {
                            Make = c.Policy.Vehicle.Make,
                            Model = c.Policy.Vehicle.Model,
                            Registration = c.Policy.Vehicle.Registration
                        }
                    }
                };
                return ret;
            }
        }
    }
}

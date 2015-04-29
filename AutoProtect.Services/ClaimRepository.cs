using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoProtect.Data;
using NHibernate.Linq;

namespace AutoProtect.Services
{
    public class ClaimRepository
    {
        public Claim GetClaimDetails(int id)
        {
            var ses = NHSession.CurrentSession;
            var claim = ses.Query<Claim>()
                .Where(x => x.Id == id)
                /*.Fetch(x => x.Policy)
                .Fetch(x => x.Policy.Holder)
                .Fetch(x => x.Policy.Vehicle)
                .Fetch(x => x.Policy.Product)*/
                .FirstOrDefault();
            return claim;
        }

    }
}

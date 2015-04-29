using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate;
using AutoProtect.Services;
using AutoProtect.Data;
using NHibernate.Linq;
using AutoProtect.Services;

namespace AutoProtect.Www.Controllers
{
    public class HomeController : Controller
    {

        [Utils.NHSessionAction]
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Utils.NHSessionAction]
        public ActionResult ClaimDetails(string id)
        {
            int cid;
            if (string.IsNullOrEmpty(id) || !Int32.TryParse(id, out cid))
            {
                return View(new Models.ClaimModel { Claim = null, SearchId = id });
            };
            var claimRepo = new ClaimRepository();
            var details = claimRepo.GetClaimDetails(cid);
            return View(new Models.ClaimModel { SearchId = id, Claim = details });
        }
    }
}

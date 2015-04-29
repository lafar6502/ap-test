using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoProtect.Data;

namespace AutoProtect.Www.Models
{
    public class ClaimModel
    {
        public string SearchId { get; set; }
        /// <summary>
        /// We're reusing an ORM-mapped object classes as models for the MVC
        /// which is usually not a great practice, but to keep it simple...
        /// </summary>
        public Claim Claim { get; set; }
    }
}
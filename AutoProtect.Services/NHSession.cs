using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace AutoProtect.Services
{
    public class NHSession
    {
        [ThreadStatic]
        private static ISession _ses;

        public static ISession CurrentSession {
            get { return _ses; }
            set { _ses = value; }
        }
    }
}

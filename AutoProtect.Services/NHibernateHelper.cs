using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using NHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Configuration;

namespace AutoProtect.Services
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null) InitializeSessionFactory();
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                  .ConnectionString(ConfigurationManager.ConnectionStrings["thedb"].ConnectionString) // Modify your ConnectionString
                              .ShowSql()
                )
                .Mappings(m =>
                          m.FluentMappings
                              .AddFromAssemblyOf<AutoProtect.Data.Claim>())
                /*.ExposeConfiguration(cfg => new SchemaExport(cfg)
                                                .Create(true, true))*/
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}

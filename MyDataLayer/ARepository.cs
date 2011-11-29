using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;

namespace MyDataLayer
{
    public class ARepository
    {

        protected Configuration Configuration;

        public ARepository()
        {
            Configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c.Is(Properties.Settings.Default["Con"].ToString())).AdoNetBatchSize(100))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ARepository>())
                .BuildConfiguration();
                
        }
        public MyEntity Get()
        {
            //using (var session = SessionFactory.OpenSession())
            //using (var transaction = session.BeginTransaction())
            //{
            //    var entity = session.Get<TEntity>(id);
            //    transaction.Commit();
            return null;//entity;
            //}
        }
    }
}

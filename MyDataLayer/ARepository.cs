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


        public ARepository()
        {
                
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

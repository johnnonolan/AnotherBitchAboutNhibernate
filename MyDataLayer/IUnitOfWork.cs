using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;


namespace MyDataLayer
{

    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }

    //public class UnitOfWorkFactory : IUnitOfWorkFactory
    //{
    //    //Configuration _configuration;
    //    //ISession _currentSession;

    //    //public UnitOfWorkFactory()
    //    //{
    //    //}

    //    //public IUnitOfWork Create()
    //    //{
    //    //    _configuration = Fluently.Configure()
    //    //        .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c.Is(Properties.Settings.Default["Con"].ToString())).AdoNetBatchSize(100))
    //    //        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ARepository>())
    //    //        .BuildConfiguration();
    //    //    return null;
    //    //}

    //    //public ISession CurrentSession
    //    //{
    //    //    get
    //    //    {
    //    //        if (_currentSession == null)
    //    //            throw new InvalidOperationException("You are not in a unit of work.");
    //    //        return _currentSession;
    //    //    }
    //    //    set { _currentSession = value; }
    //    //}

    //}


    public interface IUnitOfWork
    {
        IUnitOfWork Start();
    }

    public class UnitOfWork : IUnitOfWork
    {
            
        private IUnitOfWorkFactory _unitOfWorkFactory;

        private IUnitOfWork _innerUoW;
        private ISessionFactory _sessionFactory = 
        private ISession _currentSession;

        public static IUnitOfWork UOW { get; private set; }
        ;
        public ISession CurrentSession
        {
            get
            {
                if (_currentSession == null)
                    _currentSession = _sessionFactory.OpenSession();
                else
                {
                    _currentSession = _sessionFactory.GetCurrentSession();
                }
                return _currentSession;
            }
            set { _currentSession = value; }
        }

        public IUnitOfWork Start()
        {
            _innerUoW = _unitOfWorkFactory.Create();
            return _innerUoW;
        }
    }
}

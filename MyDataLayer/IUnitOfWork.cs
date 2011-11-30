using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;


namespace MyDataLayer
{

    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }


    public interface IUnitOfWork
    {
       // IUnitOfWork Start();
        ISession CurrentSession { get; set; }
    }

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
            
        private IUnitOfWorkFactory _unitOfWorkFactory;

        private IUnitOfWork _innerUoW;
        ISessionFactory _sessionFactory; 
        private ISession _currentSession;

        public static IUnitOfWork UOW { get; private set; }
        
        public ISession CurrentSession
        {
            get
            {
                if (_currentSession == null)
                {
                    
                    _currentSession = _sessionFactory.OpenSession();
                    
                    CurrentSessionContext.Bind(_currentSession);
                }
                else
                {
                    _currentSession = _sessionFactory.GetCurrentSession();
                }
                return _currentSession;
            }
            set { _currentSession = value; }
        }

        public void  Start()
        {
            // probs should put this elsewhere.
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c.Is(Properties.Settings.Default["Con"].ToString())).AdoNetBatchSize(100))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ARepository>())
                .ExposeConfiguration(x => x.SetProperty("current_session_context_class","thread_static"))
                .BuildConfiguration().BuildSessionFactory();
        
            //_innerUoW = _unitOfWorkFactory.Create();
            //return _innerUoW;
        }

        public void Dispose()
        {
            _currentSession.Flush();
            _currentSession.Dispose();
        }
    }
}

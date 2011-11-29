using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDataLayer
{
    public interface IUnitOfWork
    {
        IUnitOfWork Start();
    }

    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            // configure NH or something.
        }
        static IUnitOfWork _uow;

        public IUnitOfWork Start()
        {
            throw new NotImplementedException();
        }
    }
}

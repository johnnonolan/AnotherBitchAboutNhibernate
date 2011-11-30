using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDataLayer;

namespace MyServiceLayer
{
    public class MyService
    {

        public MyEntity GetMyEntity()
        {
            //start uow
            var uow = new UnitOfWork();
            uow.Start();
            var dl = new ARepository();
            dl.f

                return new MyEntity {Description = "John"};
            //finish uow
        }

    }
}

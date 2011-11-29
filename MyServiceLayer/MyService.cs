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
                
                return new MyEntity {Description = "John"};
            //finish uow
        }

    }
}

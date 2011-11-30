using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyServiceLayer;

namespace AnotherBitchAboutNHibernate.Models
{
    public class MyModels
    {
        public MyModel GetEm()
        {
            var service = new MyService();
            var myentities = service.GetMyEntities().ToList();
            var model = new MyModel {Description1 = myentities[0].Description, Description2 = myentities[1].Description};
            return model;
        }

        public MyCompositeModel GetEm2()
        {
            var service = new MyService();
            var stuff = service.GetMyCompositeEntity();
            return  new MyCompositeModel {DescriptionOuter = stuff[0], DescriptionInner = stuff[1]};

        }
    }
}
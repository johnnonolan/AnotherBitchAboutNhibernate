using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDataLayer;

namespace MyServiceLayer
{
    public class MyService
    {

        public IEnumerable<MyEntity> GetMyEntities()
        {
            using (var uow = new UnitOfWork())
            {

                uow.Start();
                var dl = new ARepository(uow);
                var entities = new List<MyEntity>();
                entities.Add(dl.Get(1));
                entities.Add(dl.Get(2));
                return entities;

            }
            
        }

        private MyEntity GetMyEntity(int Id, UnitOfWork uow)
        {
            var dl = new ARepository(uow);
            return dl.Get(Id);
              
        }

        public string[] GetMyCompositeEntity()
        {
            using (var uow = new UnitOfWork())
            {
                uow.Start();
                var dl = new ARepository(uow);
                var otherentity = dl.GetAggregate();
                var result = new string[2];
                result[0] = otherentity.Description;
                result[1] = otherentity.Children.First().Description;

                //some DTO
                return result;

            }
        }

        public void DoSomeStuff()
        {
            using (var uow = new UnitOfWork())
            {
                uow.Start();
                var dl = new ARepository(uow);
                var otherentity = dl.GetAggregate();
                otherentity.Children[1].Description = "BABY!";


                //some DTO


            }
            
        }
    }
}

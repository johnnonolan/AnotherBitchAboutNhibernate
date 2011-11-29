using FluentNHibernate.Mapping;

namespace MyDataLayer.Mapping
{
    public class MyEntityMap : ClassMap<MyEntity>
    {
        public MyEntityMap()
        {
            Id(x => x.Id);
            Map(x => x.Description);
        }
    }
}

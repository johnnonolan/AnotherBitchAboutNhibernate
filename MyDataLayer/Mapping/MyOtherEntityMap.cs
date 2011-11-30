using FluentNHibernate.Mapping;

namespace MyDataLayer.Mapping
{
    public class MyOtherEntityMap : ClassMap<MyOtherEntity>
    {
        public MyOtherEntityMap()
        {
            Id(x => x.Id);
            Map(x => x.Description);
            HasMany(x => x.Children).KeyColumn("MyOtherEntityId");

        }
    }

    public class ChildMap : ClassMap<Child>
    {
        public ChildMap()
        {
            Id(x => x.Id);
            Map(x => x.Description);

        }
    }
}

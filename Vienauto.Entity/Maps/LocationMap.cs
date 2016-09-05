using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class LocationMap : ClassMapping<Location>
    {
        public LocationMap()
        {
            Schema("hdt");
            Table("Location");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Location");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Name_Location);
            Property(x => x.ReWrite_Location);
            Bag(x => x.Products, map => map.Key(k => k.Column("Id_Location")), m => m.OneToMany());
        }
    }
}

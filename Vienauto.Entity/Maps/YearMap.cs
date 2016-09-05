using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class YearMap : ClassMapping<Year>
    {
        public YearMap()
        {
            Schema("hdt");
            Table("[Year]");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Year");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Name, c => c.Column("Name_Year"));
            ManyToOne(x => x.Model, map => map.Column("Id_Mode_Product"));
            Bag(x => x.Products, map => map.Key(k => k.Column("Year")), m => m.OneToMany());
            Bag(x => x.Cars, map => map.Key(k => k.Column("Id_Year")), m => m.OneToMany());
        }
    }
}

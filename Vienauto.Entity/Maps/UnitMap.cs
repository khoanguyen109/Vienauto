using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class UnitMap : ClassMapping<Unit>
    {
        public UnitMap()
        {
            Schema("hdt");
            Table("Unit");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Unit");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Name_Unit);
        }
    }
}

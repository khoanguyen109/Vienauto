using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class LevelMap : ClassMapping<Level>
    {
        public LevelMap()
        {
            Schema("hdt");
            Table("Level");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Level");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Name_Level);
        }
    }
}

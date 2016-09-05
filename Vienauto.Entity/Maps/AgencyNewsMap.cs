using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class AgencyNewsMap : ClassMapping<AgencyNews>
    {
        public AgencyNewsMap()
        {
            Schema("hdt");
            Table("Tintuc_Daily");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("ID_Tintuc_Daily");
                map.Generator(Generators.Identity);
            });
            Property(x => x.TieuDe);
            Property(x => x.NoiDung);
            Property(x => x.Datepost);
            ManyToOne(x => x.Agency, map => map.Column("Id_dangki"));
        }
    }
}

using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class AgencyTimeMap : ClassMapping<AgencyTime>
    {
        public AgencyTimeMap()
        {
            Schema("hdt");
            Table("AgentTime");
            Lazy(true);
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.FromSales);
            Property(x => x.ToSales);
            Property(x => x.FromServices);
            Property(x => x.ToServices);
            Property(x => x.DisplaySales);
            Property(x => x.DisplayServices);
            ManyToOne(x => x.User, map => map.Column("Id_Users"));
        }
    }
}

using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class ProvinceMap : ClassMapping<Province>
    {
        public ProvinceMap()
        {
            Schema("hdt");
            Table("TinhThanh");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_TinhThanh");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Name_TinhThanh);
            Property(x => x.ToaDoMap2);
            Property(x => x.ZoomMap2);
            Bag(x => x.Users, map => 
            {
                map.Inverse(true);
                map.Lazy(CollectionLazy.Lazy);
                map.Key(k => k.Column("Id_TinhThanh"));
            }, m => m.OneToMany());
        }
    }
}

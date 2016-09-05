using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class AvatarMap : ClassMapping<Avatar>
    {
        public AvatarMap()
        {
            Schema("hdt");
            Table("Avatar");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Avatar");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Name_Avatar);
            Property(x => x.PathAvatar);
            ManyToOne(x => x.Car, map => map.Column("Id_MName"));
        }
    }
}

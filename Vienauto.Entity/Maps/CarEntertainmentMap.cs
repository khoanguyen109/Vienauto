using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class CarEntertainmentMap : ClassMapping<CarEntertainment>
    {
        public CarEntertainmentMap()
        {
            Schema("hdt");
            Table("Entertainment");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Entertainment");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Radio);
            Property(x => x.CD_Player);
            Property(x => x.DVD_Audio);
            Property(x => x.Voice_Recognition);
            Property(x => x.Speakers);
            Property(x => x.Amplifier);
            Property(x => x.bluetooth_Compatibility);
            Property(x => x.Wifi_Compatibility);
            Property(x => x.GPS_Compability);
            Property(x => x.ThreeG_Compatibility, c => c.Column("3G_Compatibility"));
            ManyToOne(x => x.Car, map => map.Column("Id_MName"));
        }
    }
}

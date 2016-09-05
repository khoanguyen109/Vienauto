using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class CarInteriorMap : ClassMapping<CarInterior>
    {
        public CarInteriorMap()
        {
            Schema("hdt");
            Table("Interior");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Interior");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Air_Conditioning_Front);
            Property(x => x.Air_Conditioning_Rear);
            Property(x => x.Air_Filter);
            Property(x => x.Seating);
            Property(x => x.Front_Seat_Type);
            Property(x => x.Front_Head_Restraints);
            Property(x => x.Compass);
            Property(x => x.Clock);
            Property(x => x.DC_Power_outlet);
            Property(x => x.Tachometer);
            Property(x => x.Water_Temp_Gauge);
            Property(x => x.Low_Fuel_Warning);
            Property(x => x.Exterior_Temperature);
            Property(x => x.ReWrite_Seating);
            ManyToOne(x => x.Car, map => map.Column("Id_MName"));
        }
    }
}

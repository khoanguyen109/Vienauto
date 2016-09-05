using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class CarSafetyMap : ClassMapping<CarSafety>
    {
        public CarSafetyMap()
        {
            Schema("hdt");
            Table("Safety_Security");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Safety_Security");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Airbags_frontal);
            Property(x => x.Airbags_Impact);
            Property(x => x.Airbag_Curtain);
            Property(x => x.HeadLights);
            Property(x => x.Exterior_Light_Control);
            Property(x => x.Daytime_Running_Lights);
            Property(x => x.Led_Taillights);
            Property(x => x.Parking_Assist);
            Property(x => x.Alarm_System);
            Property(x => x.Door_Locks_System);
            Property(x => x.Rear_Child);
            Property(x => x.Content_Theft);
            Property(x => x.Low_Tire);
            Property(x => x.Brakes);
            Property(x => x.ABS);
            Property(x => x.Brake_Assist);
            ManyToOne(x => x.Car, map => map.Column("Id_MName"));
        }
    }
}

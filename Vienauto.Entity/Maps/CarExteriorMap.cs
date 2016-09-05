using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class CarExteriorMap : ClassMapping<CarExterior>
    {
        public CarExteriorMap()
        {
            Schema("hdt");
            Table("Exterior");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Exterior");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Front_Tires);
            Property(x => x.Front_rear);
            Property(x => x.Wheels);
            Property(x => x.DoorCount);
            Property(x => x.Rear_Window_Type);
            Property(x => x.Mirrows);
            Property(x => x.Heated_Door_Mirrows);
            Property(x => x.Sunroof);
            Property(x => x.Windshied_Wipes);
            Property(x => x.System);
            ManyToOne(x => x.Car, map => map.Column("Id_MName"));
        }
    }
}

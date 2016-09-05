using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class CarSpecificationMap : ClassMapping<CarSpecification>
    {
        public CarSpecificationMap()
        {
            Schema("hdt");
            Table("Specifications");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Specs");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Engine);
            Property(x => x.Type_Engine);
            Property(x => x.Compresstion);
            Property(x => x.CC);
            Property(x => x.Driving_Type);
            Property(x => x.Transmission_Type);
            Property(x => x.Fuel_Type);
            Property(x => x.Engine_Valvetrain);
            Property(x => x.ESS);
            Property(x => x.EBD);
            Property(x => x.Remote_Vehice);
            Property(x => x.Transmission);
            Property(x => x.Exterior_Length);
            Property(x => x.Exterior_Width);
            Property(x => x.Exterior_Height);
            Property(x => x.Horsepower);
            Property(x => x.Torque);
            Property(x => x.Drag_Coeficient);
            Property(x => x.Fuel_Economy_City);
            Property(x => x.Fuel_Economy_Highway);
            Property(x => x.TimeSpeed);
            Property(x => x.Curb_Weight);
            Property(x => x.GVWR);
            Property(x => x.Payloa);
            Property(x => x.ReWrite_DrivingType);
            Property(x => x.MPG);
            Property(x => x.Km);
            Property(x => x.Locking);
            Property(x => x.tam);
            ManyToOne(x => x.Car, map => map.Column("Id_MName"));
        }
    }
}

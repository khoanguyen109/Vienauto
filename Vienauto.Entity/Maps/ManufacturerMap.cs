using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class ManufacturerMap : ClassMapping<Manufacturer>
    {
        public ManufacturerMap()
        {
            Schema("hdt");
            Table("Manufacturer");
            Lazy(true);
            Id(x => x.Id, map => 
            {
                map.Column("Id_Manufacturer");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Name, c => c.Column("Name_Manufacturer"));
            Property(x => x.RewriteName, c => c.Column("ReWrite_Manufacturer"));
            Property(x => x.Logo, c => c.Column("logo"));
            Bag(x => x.Styles, map => map.Key(k => k.Column("Id_TypeProduct")), m => m.OneToMany());
            Bag(x => x.Products, map => map.Key(k => k.Column("Id_Manufacturer")), m => m.OneToMany());
        }
    }
}

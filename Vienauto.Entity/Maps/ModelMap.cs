using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class ModelMap : ClassMapping<Model>
    {
        public ModelMap()
        {
            Schema("hdt");
            Table("Mode_Product");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Mode_Product");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Name, c => c.Column("Name_Mode_Product"));
            Property(x => x.RewriteName, c => c.Column("ReWrite_ModeProduct"));
            Bag(x => x.Years, map => map.Key(k => k.Column("Id_Year")), m => m.OneToMany());
            ManyToOne(x => x.Style, map => map.Column("Id_TypeProduct"));
        }
    }
}

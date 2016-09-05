using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class CarMap : ClassMapping<Car>
    {
        public CarMap()
        {
            Schema("hdt");
            Table("MName");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_MName");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Name_MName);
            Property(x => x.Html_Exterior);
            Property(x => x.Html_Interior);
            Property(x => x.Html_Color);
            Property(x => x.Link_Video);
            Property(x => x.Introlduction);
            Property(x => x.Km);
            Property(x => x.Rate_Value);
            Property(x => x.Rate_Num);
            Property(x => x.LastReviews);
            Property(x => x.PathImages);
            ManyToOne(x => x.Year, map => map.Column("Id_Year"));
            Bag(x => x.Avatars, map => map.Key(k => k.Column("Id_MName")), m => m.OneToMany());
            Bag(x => x.Reviews, map => map.Key(k => k.Column("Id_MName")), m => m.OneToMany());
            Bag(x => x.Safeties, map => map.Key(k => k.Column("Id_MName")), m => m.OneToMany());
            Bag(x => x.Interiors, map => map.Key(k => k.Column("Id_MName")), m => m.OneToMany());
            Bag(x => x.Exteriors, map => map.Key(k => k.Column("Id_MName")), m => m.OneToMany());
            Bag(x => x.Entertainments, map => map.Key(k => k.Column("Id_MName")), m => m.OneToMany());
            Bag(x => x.Specifications, map => map.Key(k => k.Column("Id_MName")), m => m.OneToMany());
        }
    }
}

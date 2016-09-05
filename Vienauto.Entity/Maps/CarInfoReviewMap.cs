using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class CarInfoReviewMap : ClassMapping<CarInfoReview>
    {
        public CarInfoReviewMap()
        {
            Schema("hdt");
            Table("Reviews_ModelDetail");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Reviews");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Brand);
            Property(x => x.Model);
            Property(x => x.Year);
            Property(x => x.Point_Body);
            Property(x => x.Point_Safe);
            Property(x => x.Point_Operation);
            Property(x => x.Point_Price);
            Property(x => x.Content);
            Property(x => x.DatePost);
            ManyToOne(x => x.User, map => map.Column("Id_Users"));
        }
    }
}

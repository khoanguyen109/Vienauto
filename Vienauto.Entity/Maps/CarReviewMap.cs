using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class CarReviewMap : ClassMapping<CarReview>
    {
        public CarReviewMap()
        {
            Schema("hdt");
            Table("Reviews");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Reviews");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Point_Body);
            Property(x => x.Point_Safe);
            Property(x => x.Point_Operation);
            Property(x => x.Point_Price);
            Property(x => x.Content);
            Property(x => x.DatePost);
            Property(x => x.Active);
            ManyToOne(x => x.User, map => map.Column("Id_Users"));
            ManyToOne(x => x.Car, map => map.Column("Id_MName"));
        }
    }
}

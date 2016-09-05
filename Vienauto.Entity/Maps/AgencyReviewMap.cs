using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class AgencyReviewMap : ClassMapping<AgencyReview>
    {
        public AgencyReviewMap()
        {
            Schema("hdt");
            Table("Reviews_Agent");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Reviews");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Customer_Service);
            Property(x => x.Buying_Process);
            Property(x => x.Quality_of_Repair);
            Property(x => x.Facilities);
            Property(x => x.Overall);
            Property(x => x.Title_Review);
            Property(x => x.Content_Review);
            Property(x => x.Datetime_Review);
            Property(x => x.Name);
            Property(x => x.Email);
            Property(x => x.Phone);
            ManyToOne(x => x.User, map => map.Column("Id_Users"));
            ManyToOne(x => x.Agency, map => map.Column("Id_dangki"));
        }
    }
}

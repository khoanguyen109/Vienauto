using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class QuestionMap : ClassMapping<Question>
    {
        public QuestionMap()
        {
            Schema("hdt");
            Table("Question");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Question");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Name_Question);
        }
    }
}

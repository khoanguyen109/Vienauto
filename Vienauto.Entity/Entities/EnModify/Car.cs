using System;

namespace Vienauto.Entity.Entities
{
    public class Car : Entity
    {
        public virtual string Name_MName { get; set; }
        public virtual string Html_Exterior { get; set; }
        public virtual string Html_Interior { get; set; }
        public virtual string Html_Color { get; set; }
        public virtual string Link_Video { get; set; }
        public virtual string Introduction { get; set; }
        public virtual string Km { get; set; }
        public virtual int Rate_Value { get; set; }
        public virtual int Rate_Num { get; set; }
        public virtual DateTime? LastReviews { get; set; }
        public virtual string PathImages { get; set; }
        public virtual Year Year { get; set; }
    }
}

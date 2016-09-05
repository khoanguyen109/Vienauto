using System;

namespace Vienauto.Entity.Entities
{
    public class CarInfoReview : Entity
    {
        public virtual string Brand { get; set; }
        public virtual string Model { get; set; }
        public virtual string Year { get; set; }
        public virtual int Point_Body { get; set; }
        public virtual int Point_Safe { get; set; }
        public virtual int Point_Operation { get; set; }
        public virtual int Point_Price { get; set; }
        public virtual string Content { get; set; }
        public virtual DateTime? DatePost { get; set; }
        public virtual User User { get; set; }
    }
}

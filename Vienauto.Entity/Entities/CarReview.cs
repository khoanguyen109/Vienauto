using System;

namespace Vienauto.Entity.Entities
{
    public class CarReview : Entity
    {
        public virtual int Point_Body { get; set; }
        public virtual int Point_Safe { get; set; }
        public virtual int Point_Operation { get; set; }
        public virtual int Point_Price { get; set; }
        public virtual string Content { get; set; }
        public virtual DateTime? DatePost { get; set; }
        public virtual int Active { get; set; }
        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
    }
}

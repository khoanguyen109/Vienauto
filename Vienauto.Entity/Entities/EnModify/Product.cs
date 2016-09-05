using System;

namespace Vienauto.Entity.Entities
{
    public class Product : Entity
    {
        public virtual string Name_Product { get; set; }
        public virtual int Status { get; set; }
        public virtual float Price_Product { get; set; }
        public virtual string ReWrite_Product { get; set; }
        public virtual User User { get; set; }
        public virtual Car Car { get; set; }
    }
}

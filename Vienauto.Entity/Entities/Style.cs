using System.Collections.Generic;

namespace Vienauto.Entity.Entities
{
    public class Style : Entity
    {
        public Style()
        {
            Models = new List<Model>();
            Products = new List<Product>();
        }

        public virtual string Name { get; set; }
        public virtual string RewriteName { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual IList<Model> Models { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}

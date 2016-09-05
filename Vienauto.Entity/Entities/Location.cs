using System.Collections.Generic;

namespace Vienauto.Entity.Entities
{
    public class Location : Entity
    {
        public Location()
        {
            Products = new List<Product>();
        }

        public virtual string Name_Location { get; set; }
        public virtual string ReWrite_Location { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}

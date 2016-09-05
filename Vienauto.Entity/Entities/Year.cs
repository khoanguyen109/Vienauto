using System.Collections.Generic;

namespace Vienauto.Entity.Entities
{
    public class Year : Entity
    {
        public Year()
        {
            Cars = new List<Car>();
            Products = new List<Product>();
        }

        public virtual string Name { get; set; }
        public virtual Model Model { get; set; }
        public virtual IList<Car> Cars { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}

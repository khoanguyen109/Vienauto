using System.Collections.Generic;

namespace Vienauto.Entity.Entities
{
    public class Model : Entity
    {
        public Model()
        {
            Years = new List<Year>();
        }

        public virtual string Name { get; set; }
        public virtual string RewriteName { get; set; }
        public virtual Style Style { get; set; }
        public virtual IList<Year> Years { get; set; }
    }
}

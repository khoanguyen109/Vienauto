using System.Collections.Generic;

namespace Vienauto.Entity.Entities
{
    public class Manufacturer : Entity
    {
        public virtual string Name { get; set; }
        public virtual string RewriteName { get; set; }
        public virtual string Logo { get; set; }
        public virtual IList<Style> Styles { get; set; }
    }
}

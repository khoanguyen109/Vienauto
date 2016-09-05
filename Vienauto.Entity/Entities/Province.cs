using System.Collections.Generic;

namespace Vienauto.Entity.Entities
{
    public class Province : Entity
    {
        public virtual string Name_TinhThanh { get; set; }
        public virtual int ZoomMap2 { get; set; }
        public virtual int ToaDoMap2 { get; set; }
        public virtual IList<User> Users { get; set; }
    }
}

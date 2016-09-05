using System;

namespace Vienauto.Entity.Entities
{
    public class AgencyNews : Entity
    {
        public virtual string TieuDe { get; set; }
        public virtual string NoiDung { get; set; }
        public virtual DateTime? Datepost { get; set; }
        public virtual Agency Agency { get; set; }
    }
}

using System;

namespace Vienauto.Entity.Entities
{
    public class AgencyNews : Entity
    {
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public Agency Agency { get; set; }
        public DateTime Datepost { get; set; }
    }
}

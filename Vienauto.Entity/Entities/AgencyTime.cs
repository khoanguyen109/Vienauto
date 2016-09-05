namespace Vienauto.Entity.Entities
{
    public class AgencyTime : Entity
    {
        public virtual string FromSales { get; set; }
        public virtual string ToSales { get; set; }
        public virtual string FromServices { get; set; }
        public virtual string ToServices { get; set; }
        public virtual string DisplaySales { get; set; }
        public virtual string DisplayServices { get; set; }
        public virtual User User { get; set; }
    }
}

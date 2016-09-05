namespace Vienauto.Entity.Entities
{
    class AgencyTime : Entity
    {
        public User User { get; set; }
        public string FromSales { get; set; }
        public string ToSales { get; set; }
        public string FromServices { get; set; }
        public string ToServices { get; set; }
        public string DisplaySales { get; set; }
        public string DisplayServices { get; set; }
    }
}

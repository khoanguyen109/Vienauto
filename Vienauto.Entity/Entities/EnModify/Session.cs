namespace Vienauto.Entity.Entities
{
    public class Session
    {
        public virtual string ip_client { get; set; }
        public virtual string timelogin { get; set; }
        public virtual User User { get; set; }
    }
}

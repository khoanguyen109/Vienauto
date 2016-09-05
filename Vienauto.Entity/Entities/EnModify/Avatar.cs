namespace Vienauto.Entity.Entities
{
    public class Avatar : Entity
    {
        public virtual string Name_Avatar { get; set; }
        public virtual string PathAvatar { get; set; }
        public virtual Car Car { get; set; }
    }
}

namespace Vienauto.Entity.Entities
{
    public class ModelAvatar : Entity
    {
        public virtual string PathImage { get; set; }
        public virtual Model Model { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}

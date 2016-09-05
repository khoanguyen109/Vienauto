namespace Vienauto.Entity.Entities
{
    public class Specification : Entity
    {
        public virtual string Exterior { get; set; }
        public virtual string Front_Tires { get; set; }
        public virtual string Front_rear { get; set; }
        public virtual string Wheels { get; set; }
        public virtual int DoorCount { get; set; }
        public virtual string Rear_Window_Type { get; set; }
        public virtual string Mirrows { get; set; }
        public virtual string Heated_Door_Mirrows { get; set; }
        public virtual string Sunroof { get; set; }
        public virtual string Windshied_Wipes { get; set; }
        public virtual string System { get; set; }
        public virtual Car Car { get; set; }
    }
}

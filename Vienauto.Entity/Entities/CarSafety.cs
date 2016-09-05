namespace Vienauto.Entity.Entities
{
    public class CarSafety : Entity
    {
        public virtual string Safety_Security { get; set; }
        public virtual string Airbags_frontal { get; set; }
        public virtual string Airbags_Impact { get; set; }
        public virtual string Airbag_Curtain { get; set; }
        public virtual string HeadLights { get; set; }
        public virtual string Exterior_Light_Control { get; set; }
        public virtual string Daytime_Running_Lights { get; set; }
        public virtual string Led_Taillights { get; set; }
        public virtual string Parking_Assist { get; set; }
        public virtual string Alarm_System { get; set; }
        public virtual string Door_Locks_System { get; set; }
        public virtual string Rear_Child { get; set; }
        public virtual string Content_Theft { get; set; }
        public virtual string Low_Tire { get; set; }
        public virtual string Brakes { get; set; }
        public virtual string ABS { get; set; }
        public virtual string Brake_Assist { get; set; }
        public virtual Car Car { get; set; }
    }
}

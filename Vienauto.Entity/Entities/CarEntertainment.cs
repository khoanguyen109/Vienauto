namespace Vienauto.Entity.Entities
{
    public class CarEntertainment : Entity
    {
        public virtual string Radio { get; set; }
        public virtual string CD_Player { get; set; }
        public virtual string DVD_Audio { get; set; }
        public virtual string Voice_Recognition { get; set; }
        public virtual int Speakers { get; set; }
        public virtual string Amplifier { get; set; }
        public virtual string bluetooth_Compatibility { get; set; }
        public virtual string Wifi_Compatibility { get; set; }
        public virtual string ThreeG_Compatibility { get; set; }
        public virtual string GPS_Compability { get; set; }
        public virtual Car Car { get; set; }
    }
}

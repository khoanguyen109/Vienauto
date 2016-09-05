namespace Vienauto.Entity.Entities
{
    public class CarInterior : Entity
    {
        public virtual int Air_Conditioning_Front { get; set; }
        public virtual int Air_Conditioning_Rear { get; set; }
        public virtual int Air_Filter { get; set; }
        public virtual int Seating { get; set; }
        public virtual string Front_Seat_Type { get; set; }
        public virtual string Front_Head_Restraints { get; set; }
        public virtual string Compass { get; set; }
        public virtual string Clock { get; set; }
        public virtual int DC_Power_outlet { get; set; }
        public virtual string Tachometer { get; set; }
        public virtual string Water_Temp_Gauge { get; set; }
        public virtual string Low_Fuel_Warning { get; set; }
        public virtual string Exterior_Temperature { get; set; }
        public virtual string ReWrite_Seating { get; set; }
        public virtual Car Car { get; set; }
    }
}

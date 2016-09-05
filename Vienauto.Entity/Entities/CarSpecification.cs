namespace Vienauto.Entity.Entities
{
    public class CarSpecification : Entity
    {
        public virtual string Engine { get; set; }
        public virtual string Type_Engine { get; set; }
        public virtual string Compresstion { get; set; }
        public virtual string CC { get; set; }
        public virtual string Driving_Type { get; set; }
        public virtual string Transmission_Type { get; set; }
        public virtual string Fuel_Type { get; set; }
        public virtual string Engine_Valvetrain { get; set; }
        public virtual string ESS { get; set; }
        public virtual string EBD { get; set; }
        public virtual string Remote_Vehice { get; set; }
        public virtual string Transmission { get; set; }
        public virtual string Exterior_Length { get; set; }
        public virtual string Exterior_Width { get; set; }
        public virtual string Exterior_Height { get; set; }
        public virtual string Horsepower { get; set; }
        public virtual string Torque { get; set; }
        public virtual string Drag_Coeficient { get; set; }
        public virtual string Fuel_Economy_City { get; set; }
        public virtual string Fuel_Economy_Highway { get; set; }
        public virtual string TimeSpeed { get; set; }
        public virtual string Curb_Weight { get; set; }
        public virtual string GVWR { get; set; }
        public virtual string Payloa { get; set; }
        public virtual string ReWrite_DrivingType { get; set; }
        public virtual string MPG { get; set; }
        public virtual string Km { get; set; }
        public virtual string Locking { get; set; }
        public virtual string tam { get; set; }
        public virtual Car Car { get; set; }
    }
}

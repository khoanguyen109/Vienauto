using System;

namespace Vienauto.Entity.Entities
{
    public class Product : Entity
    {
        public virtual string Name_Product { get; set; }
        public virtual int Status { get; set; }
        public virtual float Price_Product { get; set; }
        public virtual int Index { get; set; }
        public virtual float Discount { get; set; }
        public virtual string Vin { get; set; }
        public virtual string Warranty { get; set; }
        public virtual string ReWrite_Product { get; set; }
        public virtual int New_Old { get; set; }
        public virtual DateTime? DatePost { get; set; }
        public virtual int In_Out { get; set; }
        public virtual int Km { get; set; }
        public virtual float ChietKhauNSX { get; set; }
        public virtual float ChietKhauDaiLy { get; set; }
        public virtual float PhivanChuyen { get; set; }
        public virtual float ChietKhauSC { get; set; }
        public virtual float GiamGiaSC { get; set; }
        public virtual int Like_Total { get; set; }
        public virtual int Dislike_Total { get; set; }
        public virtual DateTime? Giahan { get; set; }
        public virtual int Need { get; set; }
        public virtual int SoLanXem { get; set; }
        public virtual int Star { get; set; }
        public virtual string Path_Images { get; set; }
        public virtual int hide_price { get; set; }
        public virtual string baoduongdinhky { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual User User { get; set; }
        public virtual Car Car { get; set; }
        public virtual Year Year { get; set; }
        public virtual Style Style { get; set; }
        public virtual Location Location { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}

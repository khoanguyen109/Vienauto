using System;
using System.Collections.Generic;

namespace Vienauto.Entity.Entities
{
    public class Agency : Entity
    {
        public Agency()
        {
            News = new List<AgencyNews>();
            Reviews = new List<AgencyReview>();
        }

        public virtual string Ten_CTY { get; set; }
        public virtual string Diachi_giaodich { get; set; }
        public virtual string MaSoThue { get; set; }
        public virtual string HoTen_Nguoidaidien { get; set; }
        public virtual string Dien_thoai { get; set; }
        public virtual string Didong { get; set; }
        public virtual string Email_kichhoat { get; set; }
        public virtual string Vitri { get; set; }
        public virtual int Chinhanh { get; set; }
        public virtual string Soxe_giaodich { get; set; }
        public virtual string Xe_phanphoi { get; set; }
        public virtual string CanTuVanthem { get; set; }
        public virtual string lamsao_cokh { get; set; }
        public virtual string KH_cuaban { get; set; }
        public virtual string Banbietchungtoitudau { get; set; }
        public virtual string Banla_TV { get; set; }
        public virtual string denghi_cungcapdonhan { get; set; }
        public virtual string filedinhkem { get; set; }
        public virtual int kichhoat { get; set; }
        public virtual DateTime ngaydangki { get; set; }
        public virtual User User { get; set; }
        public virtual IList<AgencyNews> News { get; set; }
        public virtual IList<AgencyReview> Reviews { get; set; }
    }
}

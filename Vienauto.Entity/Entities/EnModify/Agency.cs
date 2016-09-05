using System;

namespace Vienauto.Entity.Entities
{
    public class Agency : Entity
    {
        public virtual string Ten_CTY { get; set; }
        public string Diachi_giaodich { get; set; }
        public string MaSoThue { get; set; }
        public string HoTen_Nguoidaidien { get; set; }
        public string Dien_thoai { get; set; }
        public string Didong { get; set; }
        public string Email_kichhoat { get; set; }
        public string Vitri { get; set; }
        public int Chinhanh { get; set; }
        public string Soxe_giaodich { get; set; }
        public string Xe_phanphoi { get; set; }
        public string CanTuVanthem { get; set; }
        public string lamsao_cokh { get; set; }
        public string KH_cuaban { get; set; }
        public string Banbietchungtoitudau { get; set; }
        public string Banla_TV { get; set; }
        public string denghi_cungcapdonhan { get; set; }
        public string filedinhkem { get; set; }
        public int kichhoat { get; set; }
        public DateTime ngaydangki { get; set; }
        public User User { get; set; }
    }
}

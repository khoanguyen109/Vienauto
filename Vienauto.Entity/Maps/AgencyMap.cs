using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class AgencyMap : ClassMapping<Agency>
    {
        public AgencyMap()
        {
            Schema("hdt");
            Table("Dangki_daili_online");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_dangki");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Ten_CTY);
            Property(x => x.Diachi_giaodich);
            Property(x => x.MaSoThue);
            Property(x => x.HoTen_Nguoidaidien);
            Property(x => x.Dien_thoai);
            Property(x => x.Didong);
            Property(x => x.Email_kichhoat);
            Property(x => x.Vitri);
            Property(x => x.Chinhanh);
            Property(x => x.Soxe_giaodich);
            Property(x => x.Xe_phanphoi);
            Property(x => x.CanTuVanthem);
            Property(x => x.lamsao_cokh);
            Property(x => x.KH_cuaban);
            Property(x => x.Banbietchungtoitudau);
            Property(x => x.Banla_TV);
            Property(x => x.denghi_cungcapdonhan);
            Property(x => x.filedinhkem);
            Property(x => x.kichhoat);
            Property(x => x.ngaydangki);
            ManyToOne(x => x.User, map => map.Column("Id_Users"));
            Bag(x => x.News, map => map.Key(k => k.Column("Id_Daily")), m => m.OneToMany());
            Bag(x => x.Reviews, map => map.Key(k => k.Column("Id_Agent")), m => m.OneToMany());
        }
    }
}

using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class UserMap : ClassMapping<User>
    {
        public UserMap()
        {
            Schema("hdt");
            Table("Users");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Users");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Avatar);
            Property(x => x.UserName);
            Property(x => x.PassWord);
            Property(x => x.FullName);
            Property(x => x.Phone);
            Property(x => x.Mobile);
            Property(x => x.Address);
            Property(x => x.Email2);
            Property(x => x.Fax);
            Property(x => x.Company);
            Property(x => x.Website);
            Property(x => x.ToaDoMap);
            Property(x => x.ZoomMap);
            Property(x => x.SubDaiLy);
            Property(x => x.Answer_Question);
            Property(x => x.Point);
            Property(x => x.Active);
            Property(x => x.TienChietKhau);
            Property(x => x.LastLogin, map => map.Column("Last_Login"));
            Property(x => x.NgayGiaNhap);
            ManyToOne(x => x.Level, map => map.Column("Id_Level"));
            ManyToOne(x => x.Question, map => map.Column("Id_Question"));
            ManyToOne(x => x.Parent, map => map.Column("Parent"));
            ManyToOne(x => x.Province, map => map.Column("TinhThanh"));
            Bag(x => x.Products, map => map.Key(k => k.Column("Id_Users")), m => m.OneToMany());
            Bag(x => x.Agencies, map => map.Key(k => k.Column("Id_user")), m => m.OneToMany());
            Bag(x => x.CarReviews, map => map.Key(k => k.Column("Id_Users")), m => m.OneToMany());
            Bag(x => x.CarInfoReviews, map => map.Key(k => k.Column("Id_Users")), m => m.OneToMany());
            Bag(x => x.AgencyTimes, map => map.Key(k => k.Column("Id_User")), m => m.OneToMany());
        }
    }
}

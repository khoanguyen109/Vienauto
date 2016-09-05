using Vienauto.Entity.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Vienauto.Entity.Maps
{
    public class ProductMap : ClassMapping<Product>
    {
        public ProductMap()
        {
            Schema("hdt");
            Table("Product");
            Lazy(true);
            Id(x => x.Id, map =>
            {
                map.Column("Id_Product");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Name_Product);
            Property(x => x.Status);
            Property(x => x.Price_Product);
            Property(x => x.Index);
            Property(x => x.Discount);
            Property(x => x.Vin);
            Property(x => x.Warranty);
            Property(x => x.ReWrite_Product);
            Property(x => x.New_Old);
            Property(x => x.DatePost);
            Property(x => x.In_Out);
            Property(x => x.Km);
            Property(x => x.ChietKhauNSX);
            Property(x => x.ChietKhauDaiLy);
            Property(x => x.PhivanChuyen);
            Property(x => x.ChietKhauSC);
            Property(x => x.GiamGiaSC);
            Property(x => x.Like_Total);
            Property(x => x.Dislike_Total);
            Property(x => x.Giahan);
            Property(x => x.Need);
            Property(x => x.SoLanXem);
            Property(x => x.Star);
            Property(x => x.Path_Images);
            Property(x => x.hide_price);
            Property(x => x.baoduongdinhky);
            ManyToOne(x => x.Car, map => map.Column("Id_MName"));
            ManyToOne(x => x.User, map => map.Column("Id_User"));
            ManyToOne(x => x.Unit, map => map.Column("Id_Unit"));
            ManyToOne(x => x.Location, map => map.Column("Id_Location"));
            ManyToOne(x => x.Year, map => map.Column("Id_Year"));
            ManyToOne(x => x.Style, map => map.Column("Id_TypeProduct"));
            ManyToOne(x => x.Manufacturer, map => map.Column("Id_Manufacturer"));
        }
    }
}

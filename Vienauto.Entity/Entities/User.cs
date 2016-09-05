using System;
using System.Collections.Generic;

namespace Vienauto.Entity.Entities
{
    public class User : Entity
    {
        public User()
        {
            Agencies = new List<Agency>();
            Products = new List<Product>();
            CarReviews = new List<CarReview>();
            CarInfoReviews = new List<CarInfoReview>();
            AgencyTimes = new List<AgencyTime>();
        }

        public virtual string Avatar { get; set; }
        public virtual string UserName { get; set; }
        public virtual string PassWord { get; set; }
        public virtual string FullName { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string Address { get; set; }
        public virtual string Email2 { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Company { get; set; }
        public virtual string Website { get; set; }
        public virtual string ToaDoMap { get; set; }
        public virtual string ZoomMap { get; set; }
        public virtual string SubDaiLy { get; set; }
        public virtual string Answer_Question { get; set; }
        public virtual int Point { get; set; }
        public virtual int Active { get; set; }
        public virtual float TienChietKhau { get; set; }
        public virtual DateTime? LastLogin { get; set; }
        public virtual DateTime? NgayGiaNhap { get; set; }
        public virtual Level Level { get; set; }
        public virtual Question Question { get; set; }
        public virtual User Parent { get; set; }
        public virtual Province Province { get; set; }
        public virtual IList<Product> Products { get; set; }
        public virtual IList<Agency> Agencies { get; set; }
        public virtual IList<CarReview> CarReviews { get; set; }
        public virtual IList<CarInfoReview> CarInfoReviews { get; set; }
        public virtual IList<AgencyTime> AgencyTimes { get; set; }
    }
}

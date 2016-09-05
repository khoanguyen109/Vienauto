using System;

namespace Vienauto.Entity.Entities
{
    public class AgencyReview : Entity
    {
        public virtual int Customer_Service { get; set; }
        public virtual int Buying_Process { get; set; }
        public virtual int Quality_of_Repair { get; set; }
        public virtual int Facilities { get; set; }
        public virtual int Overall { get; set; }
        public virtual string Title_Review { get; set; }
        public virtual string Content_Review { get; set; }
        public virtual DateTime Datetime_Review { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual User User { get; set; }
        public virtual Agency Agency { get; set; }
    }
}

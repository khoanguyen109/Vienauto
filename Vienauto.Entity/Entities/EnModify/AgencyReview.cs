using System;

namespace Vienauto.Entity.Entities
{
    public class AgencyReview : Entity
    {
        public int Customer_Service { get; set; }
        public int Buying_Process { get; set; }
        public int Quality_of_Repair { get; set; }
        public int Facilities { get; set; }
        public int Overall { get; set; }
        public string Title_Review { get; set; }
        public string Content_Review { get; set; }
        public DateTime Datetime_Review { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public User User { get; set; }
        public Agency Agency { get; set; }
    }
}

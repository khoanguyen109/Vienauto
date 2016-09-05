using System;
using System.Collections.Generic;

namespace Vienauto.Entity.Entities
{
    public class Car : Entity
    {
        public Car()
        {
            Avatars = new List<Avatar>();
            Reviews = new List<CarReview>();
            Safeties = new List<CarSafety>();
            Interiors = new List<CarInterior>();
            Exteriors = new List<CarExterior>();
            Entertainments = new List<CarEntertainment>();
            Specifications = new List<CarSpecification>();
        }

        public virtual string Name_MName { get; set; }
        public virtual string Html_Exterior { get; set; }
        public virtual string Html_Interior { get; set; }
        public virtual string Html_Color { get; set; }
        public virtual string Link_Video { get; set; }
        public virtual string Introlduction { get; set; }
        public virtual string Km { get; set; }
        public virtual int Rate_Value { get; set; }
        public virtual int Rate_Num { get; set; }
        public virtual DateTime? LastReviews { get; set; }
        public virtual string PathImages { get; set; }
        public virtual Year Year { get; set; }
        public virtual IList<Avatar> Avatars { get; set; }
        public virtual IList<CarReview> Reviews { get; set; }
        public virtual IList<CarSafety> Safeties { get; set; }
        public virtual IList<CarInterior> Interiors { get; set; }
        public virtual IList<CarExterior> Exteriors { get; set; }
        public virtual IList<CarEntertainment> Entertainments { get; set; }
        public virtual IList<CarSpecification> Specifications { get; set; }
    }
}

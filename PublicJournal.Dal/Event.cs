//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PublicJournal.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public Event()
        {
            this.EventTestimonials = new HashSet<EventTestimonial>();
            this.UserEventHistories = new HashSet<UserEventHistory>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int GenericEventId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public decimal TicketPrice { get; set; }
        public int FlightId { get; set; }
        public int HotelId { get; set; }
    
        public virtual GenericEvent GenericEvent { get; set; }
        public virtual ICollection<EventTestimonial> EventTestimonials { get; set; }
        public virtual ICollection<UserEventHistory> UserEventHistories { get; set; }
    }
}

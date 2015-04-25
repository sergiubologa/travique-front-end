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
    
    public partial class UserEventHistory
    {
        public UserEventHistory()
        {
            this.EventRevenues = new HashSet<EventRevenue>();
        }
    
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public int HotelId { get; set; }
        public int FlightId { get; set; }
        public int NoOfPersons { get; set; }
        public decimal Revenues { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual ICollection<EventRevenue> EventRevenues { get; set; }
        public virtual FlightInfo FlightInfo { get; set; }
        public virtual HotelInfo HotelInfo { get; set; }
        public virtual User User { get; set; }
    }
}

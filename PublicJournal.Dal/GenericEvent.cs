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
    
    public partial class GenericEvent
    {
        public GenericEvent()
        {
            this.Events = new HashSet<Event>();
            this.EventCategories = new HashSet<EventCategory>();
            this.EventTestimonials = new HashSet<EventTestimonial>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<EventCategory> EventCategories { get; set; }
        public virtual ICollection<EventTestimonial> EventTestimonials { get; set; }
    }
}

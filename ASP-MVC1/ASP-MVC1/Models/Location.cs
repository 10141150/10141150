//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_MVC1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        public Location()
        {
            this.Device = new HashSet<Device>();
        }
    
        public int id_location { get; set; }
        public string department { get; set; }
        public string responsible { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<Device> Device { get; set; }
    }
}

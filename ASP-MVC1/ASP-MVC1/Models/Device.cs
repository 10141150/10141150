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
    
    public partial class Device
    {
        public Device()
        {
            this.Contract = new HashSet<Contract>();
        }
    
        public int id_device { get; set; }
        public string name { get; set; }
        public string unam_stock_number { get; set; }
        public int location_id { get; set; }
        public string serial_number { get; set; }
    
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual Location Location { get; set; }
    }
}

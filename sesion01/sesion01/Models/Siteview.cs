//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sesion01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Siteview
    {
        public int id_siteview { get; set; }
        public int contract_id { get; set; }
        public Nullable<System.DateTime> visit_date { get; set; }
        public Nullable<bool> completed { get; set; }
    
        public virtual Contract Contract { get; set; }
    }
}

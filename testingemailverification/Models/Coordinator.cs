//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testingemailverification.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coordinator
    {
        public int cid { get; set; }
        public string CoordinatorName { get; set; }
        public int scid { get; set; }
        public int dcid { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Semster Semster { get; set; }
    }
}
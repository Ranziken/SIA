//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapstoneProj3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PEO
    {
        public int Peo_ID { get; set; }
        public string Peo_CODE { get; set; }
        public string Peo_DESC { get; set; }
        public string Peo_CVA { get; set; }
        public int Syllabus_ID { get; set; }
    
        public virtual PEO PEO1 { get; set; }
        public virtual PEO PEO2 { get; set; }
        public virtual PEO PEO11 { get; set; }
        public virtual PEO PEO3 { get; set; }
        public virtual Syllab Syllab { get; set; }
    }
}
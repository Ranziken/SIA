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
    
    public partial class GradingSystem
    {
        public int GRD_Id { get; set; }
        public string GRD_outputs { get; set; }
        public string GRD_type { get; set; }
        public string GRD_weight { get; set; }
        public int Syllabus_ID { get; set; }
    
        public virtual GradingSystem GradingSystem1 { get; set; }
        public virtual GradingSystem GradingSystem2 { get; set; }
        public virtual Syllab Syllab { get; set; }
    }
}

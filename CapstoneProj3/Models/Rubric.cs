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
    
    public partial class Rubric
    {
        public int id { get; set; }
        public string outstanding { get; set; }
        public string competent { get; set; }
        public string marginal { get; set; }
        public string notAcceptable { get; set; }
        public string criteria { get; set; }
        public Nullable<int> Syllabus_ID { get; set; }
    
        public virtual Syllab Syllab { get; set; }
    }
}

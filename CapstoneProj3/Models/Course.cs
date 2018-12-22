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
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.Classes = new HashSet<Class>();
            this.Syllabs = new HashSet<Syllab>();
        }
    
        public int Course_ID { get; set; }
        public string Course_Name { get; set; }
        public string Course_Dept { get; set; }
        public int Course_Credit { get; set; }
        public string Course_Equivalent { get; set; }
        public string Course_Pre_Req { get; set; }
        public string Course_Co_Req { get; set; }
        public string Course_Desc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Syllab> Syllabs { get; set; }
    }
}
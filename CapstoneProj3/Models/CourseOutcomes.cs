using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneProj3.Models
{
    public class CourseOutcomes
    {
        public int CO_ID { get; set; }
        public string CO_Code { get; set; }
        public string CO_DESC { get; set; }
        public string CO_CVA { get; set; }
        public string CO_POactivated { get; set; }
        public string CO_DOLLevel { get; set; }
        public int Syllabus_ID { get; set; }
       
    }
}
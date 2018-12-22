using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneProj3.Models
{
    public class CourseDeliverableOutputsAndRequirements
    {
        public int CODOR_ID { get; set; }
        public string OutputReq { get; set; }
        public string OutputReqDesc { get; set; }
        public string Cilo_Add { get; set; }
        public string ToA { get; set; }
        public int Syllabus_ID { get; set; }
    }
}
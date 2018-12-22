using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneProj3.Models
{
    public class Syll
    {
        //public int Syllabus_ID { get; set; } = 0;
        //public int Course_ID { get; set; } = 0;
        //public int User_ID { get; set; } = 0;
        //public List<> Lr { get; set; }
        
        public List<Rubric> Lr { get; set; }
        public List<CourseOutcome> Lco { get; set; }
        //public DMISEntitiesxx db;

        //public string CO_Code { get; set; } = string.Empty;
        //public string CO_DESC { get; set; } = string.Empty;
        //public string CO_CVA { get; set; } = string.Empty;
        //public string CO_POactivated { get; set; } = string.Empty;
        //public string CO_DOLLevel { get; set; } = string.Empty;

        //public string Course_Name { get; set; } = string.Empty;
        //public string Course_Dept { get; set; } = string.Empty;
        //public int Course_Credit { get; set; } = 0;
        //public string Course_Equivalent { get; set; } = string.Empty;
        //public string Course_Pre_Req { get; set; } = string.Empty;
        //public string Course_Co_Req { get; set; } = string.Empty;
        //public string Course_Desc { get; set; } = string.Empty;

        public List<CourseDeliverableOutputsAndRequirement> Lcodor { get; set; }

        //public string OutputReq { get; set; } = string.Empty;
        //public string OutputReqDesc { get; set; } = string.Empty;
        //public string Cilo_Add { get; set; } = string.Empty;
        //public string ToA { get; set; } = string.Empty;

        public List<ClassroomAndLabPolicy> Lclp { get; set; }

        //public string CLP_desc { get; set; } = string.Empty;

        public List<LearningPlan> Llplan { get; set; }

        //public string LPlan_Outcome { get; set; } = string.Empty;
        //public int LPlan_No_hours { get; set; } = 0;
        //public string LPlan_Topics { get; set; } = string.Empty;
        //public int LPlan_TLA_ID { get; set; } = 0;
        //public string LPlan_Asses { get; set; } = string.Empty;

        public List<PEO> Lpeo { get; set; }

        //public string Peo_CODE { get; set; } = string.Empty;
        //public string Peo_DESC { get; set; } = string.Empty;
        //public string Peo_CVA { get; set; } = string.Empty;

        public List<ProgramOutcome> Lpo { get; set; }
      
        public int num { get; set; } = 0;
        public List<GradingSystem> Lgs { get; set; }
        //public string PO_Code { get; set; } = string.Empty;
        //public string PO_attr { get; set; } = string.Empty;
        //public string PO_Desc { get; set; } = string.Empty;
        //public string PO_CVA { get; set; } = string.Empty;



    }

}
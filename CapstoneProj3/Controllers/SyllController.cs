
using CapstoneProj3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstoneProj3.Controllers
{
    public class SyllController : Controller
    {
        // GET: Syll
        DMISEntitiesxx db = new DMISEntitiesxx();
        public int logID=1;

        public ActionResult Index()
        {
            return View();
        }

        // GET: Syll/Details
        public ActionResult Details()
        {

            //var syll = new Models.Syll { Syllabus_ID = 123, Course_ID = 321, User_ID = 222 };
            AllSyllView all = new AllSyllView();
            List<Syll> butangView = new List<Syll>();
            
            List<Syllab> lsylstore = new List<Syllab>();
            List<Syllab> lsyl = new List<Syllab>();
            lsyl = db.Syllabs.ToList();
            foreach (var sud in lsyl)
            {
                if (sud.User_ID == this.logID)
                {
                    lsylstore.Add(sud);
                    
                }
            }

          
            List<CourseOutcome> Co = new List<CourseOutcome>();
            Co = db.CourseOutcomes.ToList();
            List<PEO> Peo = new List<PEO>();
            Peo = db.PEOs.ToList();
            List<ProgramOutcome> Po = new List<ProgramOutcome>();
            Po = db.ProgramOutcomes.ToList();
            List<ClassroomAndLabPolicy> Clp = new List<ClassroomAndLabPolicy>();
            Clp = db.ClassroomAndLabPolicies.ToList();
            List<CourseDeliverableOutputsAndRequirement> Codor = new List<CourseDeliverableOutputsAndRequirement>();
            Codor = db.CourseDeliverableOutputsAndRequirements.ToList();
            List<LearningPlan> Lp = new List<LearningPlan>();
            Lp = db.LearningPlans.ToList();
            List<GradingSystem> Gs = new List<GradingSystem>();
            Gs = db.GradingSystems.ToList();


            List<CourseOutcome> wCo = new List<CourseOutcome>();
            List<PEO> wPeo = new List<PEO>();
            List<ProgramOutcome> wPo = new List<ProgramOutcome>();
            List<ClassroomAndLabPolicy> wClp = new List<ClassroomAndLabPolicy>();
            List<CourseDeliverableOutputsAndRequirement> wCodor = new List<CourseDeliverableOutputsAndRequirement>();
            List<LearningPlan> wLp = new List<LearningPlan>();
            List<GradingSystem> wGs = new List<GradingSystem>();

            foreach (Syllab tanan in lsylstore)
            {
                Syll kuhaUsa = new Syll();
                
                foreach (var sud in Co)
                {
                    if (sud.Syllabus_ID == tanan.Syllabus_ID)
                    {
                        //CourseOutcome Coln = new CourseOutcome();
                        //kuhaUsa.Lco.Add(sud);
                        //Coln.Add(sud);
                        wCo.Add(sud);
                        
                       

                    }
                }
                foreach (var sud in Peo)
                {
                    if (sud.Syllabus_ID == tanan.Syllabus_ID)
                    {
                        //kuhaUsa.Lpeo.Add(sud);
                        wPeo.Add(sud);
                    }
                }
                foreach (var sud in Po)
                {
                    if (sud.Syllabus_ID == tanan.Syllabus_ID)
                    {
                        wPo.Add(sud);
                    }
                }
                foreach (var qwe in Clp)
                {
                    
                    if (qwe.Syllabus_ID == tanan.Syllabus_ID)
                    {

                        //kuhaUsa.Lclp.Add(qwe);
                        wClp.Add(qwe);
                      
                    }
                }
                foreach (var sud in Lp)
                {
                    if (sud.Syllabus_ID == tanan.Syllabus_ID)
                    {
                        //kuhaUsa.Llplan.Add(sud);
                        wLp.Add(sud);
                    }
                }
                foreach (var sud in Codor)
                {
                    if (sud.Syllabus_ID == tanan.Syllabus_ID)
                    {
                        wCodor.Add(sud);
                    }
                }
                foreach (var sud in Gs)
                {
                    if (sud.Syllabus_ID == tanan.Syllabus_ID)
                    {
                        wGs.Add(sud);
                    }
                }
                kuhaUsa.Lclp = wClp;
                kuhaUsa.Lco = wCo;
                kuhaUsa.Lcodor = wCodor;
                kuhaUsa.Lgs = wGs;
                kuhaUsa.Llplan = wLp;
                kuhaUsa.Lpeo = wPeo;
                kuhaUsa.Lpo = wPo;

                butangView.Add(kuhaUsa);
            }

            all.oru = butangView;
            return View(butangView);
        }

        // GET: Syll/Create
        public ActionResult Create()
        {
            Syll sy = new Syll();
            
            return View();
        }

        // POST: Syll/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Syll/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Syll/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Syll/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Syll/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult InsertSyll(Syll data)
        {
            List<Syllab> kita = new List<Syllab>();
            Syllab res = new Syllab();
            Syllab syllabus = new Syllab();


            

            syllabus.User_ID = logID;
            syllabus.Course_ID = 1;
            //IList<Syllab> syllablist = new List<Syllab>();
            db.Syllabs.Add(syllabus);

            
            kita=db.Syllabs.ToList();
            
            foreach(var sud in kita)
            {
                if (sud.Course_ID == syllabus.Course_ID)
                {
                    res = sud;
                    break;
                }
            }

            foreach (PEO p in data.Lpeo)
            {
                if (p.Peo_CODE !=null && p.Peo_CVA !=null  && p.Peo_DESC !=null) {
                    PEO peo = new PEO();
                    peo.Peo_CODE = p.Peo_CODE;
                    peo.Peo_DESC = p.Peo_DESC;
                    peo.Peo_CVA = p.Peo_CVA;
                    peo.Syllabus_ID = res.Syllabus_ID;

                    db.PEOs.Add(peo);

                    db.SaveChanges();
                }
            }

            foreach (ClassroomAndLabPolicy p in data.Lclp)
            {
                if (p.CLP_desc !=null) {
                    ClassroomAndLabPolicy classroomAndLabPolicies = new ClassroomAndLabPolicy();
                    classroomAndLabPolicies.CLP_desc = p.CLP_desc;
                    classroomAndLabPolicies.Syllabus_ID = res.Syllabus_ID;
                    db.ClassroomAndLabPolicies.Add(classroomAndLabPolicies);
                    db.SaveChanges();
                }
            }

            foreach (CourseDeliverableOutputsAndRequirement p in data.Lcodor)
            {
                if (p.OutputReq != null && p.OutputReqDesc != null && p.ToA!=null && p.Cilo_Add!=null) {
                    CourseDeliverableOutputsAndRequirement courseDeliverableOutputsAndRequirements = new CourseDeliverableOutputsAndRequirement();
                    courseDeliverableOutputsAndRequirements.OutputReq = p.OutputReq;
                    courseDeliverableOutputsAndRequirements.OutputReqDesc = p.OutputReqDesc;
                    courseDeliverableOutputsAndRequirements.Cilo_Add = p.Cilo_Add;
                    courseDeliverableOutputsAndRequirements.ToA = p.ToA;
                    courseDeliverableOutputsAndRequirements.Syllabus_ID = res.Syllabus_ID;
                    db.CourseDeliverableOutputsAndRequirements.Add(courseDeliverableOutputsAndRequirements);
                    db.SaveChanges();
                }
            }
            foreach (CourseOutcome p in data.Lco)
            {
                if (p.CO_Code != null && p.CO_CVA != null && p.CO_DESC != null && p.CO_DOLLevel != null & p.CO_POactivated != null) {
                    CourseOutcome courseOutcomes = new CourseOutcome();

                    courseOutcomes.CO_Code = p.CO_Code;
                    courseOutcomes.CO_DESC = p.CO_DESC;
                    courseOutcomes.CO_CVA = p.CO_CVA;
                    courseOutcomes.CO_POactivated = p.CO_POactivated;
                    courseOutcomes.CO_DOLLevel = p.CO_DOLLevel;
                    courseOutcomes.Syllabus_ID = res.Syllabus_ID;

                    db.CourseOutcomes.Add(courseOutcomes);

                    db.SaveChanges();
                }
            }
            foreach (GradingSystem p in data.Lgs)
            {
                if (p.GRD_outputs != null && p.GRD_type!= null && p.GRD_weight != null )
                {
                    GradingSystem gradingSystem = new GradingSystem();

                    gradingSystem.GRD_outputs = p.GRD_outputs;
                    gradingSystem.GRD_type = p.GRD_type;
                    gradingSystem.GRD_weight = p.GRD_weight;

                    gradingSystem.Syllabus_ID = res.Syllabus_ID;

                    db.GradingSystems.Add(gradingSystem);

                    db.SaveChanges();
                }
            }
            foreach (LearningPlan p in data.Llplan)
            {
                if (p.activityL != null && p.activityT != null & p.LPlan_Asses != null && p.LPlan_No_hours != 0 && p.LPlan_Outcome != null && p.LPlan_Topics != null)
                {
                    LearningPlan learningPlan = new LearningPlan();
                    learningPlan.LPlan_Outcome = p.LPlan_Outcome;
                    learningPlan.LPlan_No_hours = p.LPlan_No_hours;
                    learningPlan.LPlan_Topics = p.LPlan_Topics;
                    learningPlan.LPlan_Asses = p.LPlan_Asses;
                    learningPlan.activityL = p.activityL;
                    learningPlan.activityT = p.activityT;
                    learningPlan.Syllabus_ID = res.Syllabus_ID;

                    db.LearningPlans.Add(learningPlan);

                    db.SaveChanges();
                }
            }
            
            foreach (ProgramOutcome p in data.Lpo)
            {
                if (p.PO_Code != null && p.PO_attr != null & p.PO_CVA != null && p.PO_Desc!=null) {
                    ProgramOutcome programOutcome = new ProgramOutcome();
                    programOutcome.PO_Code = p.PO_Code;
                    programOutcome.PO_attr = p.PO_attr;
                    programOutcome.PO_Desc = p.PO_Desc;
                    programOutcome.PO_CVA = p.PO_CVA;
                    programOutcome.Syllabus_ID = res.Syllabus_ID;

                    db.ProgramOutcomes.Add(programOutcome);

                    db.SaveChanges();
                }
            }
            foreach (Rubric p in data.Lr)
            {
                if (p.marginal != null && p.notAcceptable != null & p.outstanding != null && p.competent != null && p.criteria != null)
                {
                    Rubric rubric = new Rubric();
                    rubric.competent = p.competent;
                    rubric.criteria = p.criteria;
                    rubric.marginal = p.marginal;
                    rubric.notAcceptable = p.notAcceptable;
                    rubric.outstanding = p.outstanding;
                    rubric.Syllabus_ID = res.Syllabus_ID;

                    db.Rubrics.Add(rubric);

                    db.SaveChanges();
                }
            }



            return View();
        }

        [HttpGet]
        public ActionResult Cr8CourseGet()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Cr8CoursePost(Course x)
        {
            Course q = new Course();
            q.Course_Name = x.Course_Name;
            q.Course_Co_Req = x.Course_Co_Req;
            q.Course_Credit = x.Course_Credit;
            q.Course_Dept = x.Course_Dept;
            q.Course_Desc = x.Course_Desc;
            q.Course_Equivalent = x.Course_Equivalent;
            q.Course_Pre_Req = x.Course_Pre_Req;
            db.Courses.Add(q);
            db.SaveChanges();
            return RedirectToAction("Details");
        }

        [HttpGet]
        public ActionResult pickCourse()
        {
            var courses = db.Courses.ToList();
            DropDownCourse res = new DropDownCourse();
            res.lcr = courses;
            return View(res);
        }
        [HttpPost]
        public ActionResult pickedCourse(DropDownCourse c)
        {
            var cont = db.Courses.ToList();

            Course res = new Course();

            foreach (var sud in cont)
            {
                if (sud.Course_ID == c.cr.Course_ID)
                {
                    res = sud;
                    break;
                }
            }

            return View(res);
        }

        [HttpGet]
        public ActionResult login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult loginIn(User u)
        {
            int flag = 0;
            var cont = db.Users.ToList();
            User res = new User();

            foreach (var sud in cont)
            {
                if (sud.ID_Num == u.ID_Num && sud.Password == u.Password)
                {
                    res = sud;
                    ++flag;
                }
            }
            if(flag >= 1)
            {
                return View(res);
            }
            else
            {
                //return RedirectToAction("Index","Syll");
                return View("~/Views/Syll/login.cshtml");
            }
            
        }
    }
}

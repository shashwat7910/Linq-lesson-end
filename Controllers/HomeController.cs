using LessonEndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LessonEndProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            StudentQuery obj = new StudentQuery();
            List<Student> stu = obj.getData();
            return View(stu);
        }

        public ActionResult About()
        {
            StudentQuery s = new StudentQuery();
            List<Student> s1 = s.getstudentwithlowestandhighestmarks();
            return View(s1);
        }

        public ActionResult Contact()
        {
            StudentQuery s1 = new StudentQuery();
            return View(s1);
        }
    }
}
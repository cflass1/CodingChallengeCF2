using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Entity;
using CodingChallengeCF2.Models;


namespace CodingChallengeCF2.Controllers
{

    public class HomeController : Controller
    {
     
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LoadData()
        {
           
                using (DatabaseContext _context = new DatabaseContext())
                {

                    List<Thing> data = _context.Things.ToList();

                    return Json(new { data = data });
                }


        }
    }
}
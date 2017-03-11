using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitApp.Models;

namespace FitApp.App_Start
{
    public class WorkoutController : Controller
    {
        private ApplicationDbContext _context;

        public WorkoutController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Workout
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter()
        {
            return View();
        }



    }
}
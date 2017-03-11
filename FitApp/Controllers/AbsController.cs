using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitApp.Models;
using Microsoft.Ajax.Utilities;

namespace FitApp.Controllers
{
    public class AbsController : Controller
    {
        private ApplicationDbContext _context;

        public AbsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Abs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Workout(int NumberOfExercises, string ExerciseLevel, string pullupbar, string abwheel, string weights)
        {
            bool hasEquipment = !(pullupbar.IsNullOrWhiteSpace() && abwheel.IsNullOrWhiteSpace() && weights.IsNullOrWhiteSpace());
            List<Abs> exercises;

            if (hasEquipment)
            {
                exercises = _context.Abs.OrderBy(e => Guid.NewGuid())
                    .Where(e => (e.ExerciseLevel == ExerciseLevel
                                 && (hasEquipment
                                     || e.ExerciseEquipment == pullupbar
                                     || e.ExerciseEquipment == abwheel
                                     || e.ExerciseEquipment == weights
                                     ))).Take(NumberOfExercises).ToList();
            }
            else
            {
                exercises = _context.Abs.OrderBy(e => Guid.NewGuid())
                    .Where(e => (e.ExerciseLevel == ExerciseLevel && e.ExerciseEquipment == "none")).Take(NumberOfExercises).ToList();
            }
            

            if (!exercises.Any())
                return new HttpNotFoundResult();
            else
                return View(exercises);
        }
    }
}
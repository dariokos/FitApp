using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FitApp.Models;

namespace FitApp.Controllers.Api
{
    public class ExercisesController : ApiController
    {
        private ApplicationDbContext _context;

        public ExercisesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/workouts
        public IEnumerable<Exercises> GetExercises(string term)
        {
            return _context.Exercises.Where(c => c.ExerciseName.Contains(term));
        }

        //POST /api/workouts
        [HttpPost]
        public Exercises CreateExercises(Exercises exercises)
        {


            _context.Exercises.Add(exercises);
            _context.SaveChanges();

            return exercises;
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FitApp.Models;

namespace FitApp.Controllers.Api
{
    public class WorkoutsController : ApiController
    {
        private ApplicationDbContext _context;

        public WorkoutsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/workouts
        public IEnumerable<Workouts> GetWorkouts()
        {
            return _context.Workouts.ToList();
        }

        //POST /api/workouts
        [HttpPost]
        public void CreateWorkout(string ExerciseName, byte first, byte second, byte third, byte fouth, byte fifth)
        {
            var exerciseId = _context.Exercises.Where(c => c.ExerciseName == ExerciseName).ToList();
            
            
                
                       

           
            _context.SaveChanges();

            
        }

        

    }
}

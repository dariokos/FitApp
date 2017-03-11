using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FitApp.Models
{
    public class Workouts
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkoutId { get; set; }
        [Required]
        public int ExerciseId { get; set; }
        [Required]
        public DateTime WorkoutDate { get; set; }
        [Required]
        public byte FirstSet { get; set; }
        public byte SecondSet { get; set; }
        public byte ThirdSet { get; set; }
        public byte FourthSet { get; set; }
        public byte FifthSet { get; set; }
    }
}
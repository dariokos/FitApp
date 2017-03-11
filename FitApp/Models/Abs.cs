using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitApp.Models
{
    public class Abs
    {
        [Key]
        [Required]
        public byte ExerciseId { get; set; }
        [Required]
        public string ExerciseName { get; set; }
        [Required]
        public string ExerciseLevel { get; set; }
        [Required]
        public string ExerciseEquipment { get; set; }

    }
}
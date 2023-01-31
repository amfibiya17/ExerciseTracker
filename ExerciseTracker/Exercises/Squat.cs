﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Exercises
{
    public class Squat : IExercise
    {
        public int Reps { get; set; }
        public int Sets { get; set; }
        public int Weight { get; set; }

        public string Report()
        {
            return $"Squat: {Reps} reps, {Sets} sets, {Weight}kg";
        }
    }
}
